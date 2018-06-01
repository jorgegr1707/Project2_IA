using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairDistribution
{
    class GeneticAlgorithm
    {
        Controller controller = Controller.GetInstance();
        List<List<Agent>> population;
        List<float> fitness;
        int limit_gens;
        Double mutation_percent;
        Random random = new Random();

        public GeneticAlgorithm()
        {
            population = new List<List<Agent>>();
            fitness = new List<float>();
            limit_gens = 500;
            mutation_percent = 0.02;
        }

        //initial population
        public void generate_population()
        {
            for (int i = 0; i < limit_gens; i++)
            {
                List<Agent> individual = new List<Agent>();
                for (int j = 0; j < controller.orders.Count; j++)
                {
                    individual.Add((Agent) controller.agents[random.Next(controller.agents.Count)]);

                }
                individual = check_distribution(individual);
                population.Add(individual);

            }
            
        }
        //check if every agent has a order (minimum)
        public List<Agent> check_distribution(List<Agent> individual)
        {
            foreach(Agent agent in controller.agents)
            {
                if (!individual.Contains(agent))
                {
                    individual[random.Next(individual.Count)] = agent;
                }
            }
            return individual;
        }

        public Service find_service(Order order)
        {
            foreach(Service service in controller.services)
            {
                if(service.Code == order.ServiceCode)
                {
                    return service;
                }
            }
            return null;
        }

        //calculate commission for every agent
        public List<int> commission_agents(List<Agent> individual)
        {
            List<int> commissions = new List<int>();
            for(int i = 0; i < individual.Count; i++)
            {
                int sum = 0;
                for (int j = 0; j < controller.agents.Count; j++)
                {
                    if (controller.agents[j].Equals(individual[i]))
                    {
                        Order order = (Order)controller.orders[i];
                        sum = find_service(order).Commission;
                    }
                }
                commissions.Add(sum);
            }
            return commissions;
        }

        //calculate varaince between commissions for each agent
        public float variance(List<int> individual)
        {
            double average = 0;
            foreach(int commission in individual)
            {
                average += commission;
            }
            average = average / individual.Count;

            double sqDiff = 0;
            foreach (int commission in individual)
            {
                sqDiff += (commission - average) * (commission - average);
            }

            return (float)sqDiff/ individual.Count;

        }

        public bool infinite_fitness(List<Agent> individual)
        {
            for (int i = 0; i < individual.Count; i++)
            {
                int hours = 0;
                for (int j = 0; j < controller.agents.Count; j++)
                {
                    if (controller.agents[j].Equals(individual[i]))
                    {
                        Order order = (Order)controller.orders[i];
                        Agent agent = (Agent)controller.agents[j];
                        hours = find_service(order).Duration;
                        if(hours > 40 || !agent.ServiceCodes.Contains(order.ServiceCode))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public void calculate_fitness()
        {
            foreach(List<Agent> individual in population)
            {
                if(infinite_fitness(individual))
                {
                    fitness.Add((float)int.MaxValue);
                }
                else
                {
                    fitness.Add(variance(commission_agents(individual)));
                }
                
            }
        }

        public void mutation()
        {
            for (int j = 0; j < population.Count; j++)
            {
                List<Agent> individual = (List<Agent>)population[j];
                for (int i = 0; i < individual.Count; i++)
                {
                    double random_mutate = (Double)(random.Next(100) / 100);
                    if (random_mutate < mutation_percent)
                    {
                        int lenght = random.Next(controller.agents.Count);
                        individual[i] = (Agent)controller.agents[lenght];
                    }
                    
                }
                individual = check_distribution(individual);
            }
        }

       
    }
}
