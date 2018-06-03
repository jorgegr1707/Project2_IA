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
        ArrayList agents;
        ArrayList orders;
        ArrayList services;
        public List<List<Agent>> population;
        List<float> fitness;
        int limit_gens;  //limit of generations
        Double mutation_percent;
        Random random = new Random();

        public GeneticAlgorithm(ArrayList agents, ArrayList orders, ArrayList services)
        {
            this.agents = agents;
            this.orders = orders;
            this.services = services;
            population = new List<List<Agent>>();
            fitness = new List<float>();
            limit_gens = 500;
            mutation_percent = 0.02;
        }

        //initial population
        public void generate_population()
        {
            for (int i = 0; i < 10; i++)
            {
                List<Agent> individual = new List<Agent>();
                for (int j = 0; j < orders.Count; j++)
                {
                    individual.Add(agents[random.Next(agents.Count)] as Agent);

                }
                individual = check_distribution(individual);
                population.Add(individual);

            }

            /*Debug part*/
            int pos = 0;
            foreach(List<Agent> agents in population)
            {
                Console.WriteLine("Individual: " + pos);
                foreach(Agent agent in agents)
                {
                    Console.WriteLine("\tID: " + agent.ID + ", name: " + agent.Name);
                }
                pos++;
            }
            /*End debug part*/
            
        }

        public int find_repeated(List<Agent> individual)
        {;
            for(int i = 0; i < individual.Count; i++)
            {
                for(int j = i+1; j < individual.Count; j++)
                {
                    if(individual[i].Equals(individual[j]))
                    {
                        return j;
                    }
                }
            }
            return individual.Count; 

        }

        //check if every agent has a order (minimum)
        public List<Agent> check_distribution(List<Agent> individual)
        {
            foreach(Agent agent in agents)
            {
                if (!individual.Contains(agent))
                {
                    individual[find_repeated(individual)] = agent;
                }
            }
            return individual;
        }

        public Service find_service(Order order)
        {
            foreach(Service service in services)
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
                Console.WriteLine(individual[i].Name);
                int sum = 0;
                for (int j = 0; j < agents.Count; j++)
                {
                    if (agents[j].Equals(individual[i]))
                    {
                        Order order = (Order)orders[i];
                        sum += find_service(order).Commission;
                    }
                }
                commissions.Add(sum);
            }

            /* Debug part 
            foreach(int commission in commissions)
            {
                Console.WriteLine(commission);
            }
            /* End debug part*/

            return commissions;
        }

        //calculate variance between commissions for each agent
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

        /*public List<Agent> change_agent(List<Agent> individual)
        {
            for(int i = 0; i < orders.Count; i++)
            {
                for(int j = )
                Order order = (Order)orders[i];
                if(agent.ServiceCodes.Contains(order.ServiceCode))
                {
                    Agent change = 
                }
            }
        }*/

       public bool infinite_fitness(List<Agent> individual)
        {
            for (int i = 0; i < individual.Count; i++)
            {
                int hours = 0;
                for (int j = 0; j < agents.Count; j++)
                {
                    if (agents[j].Equals(individual[i]))
                    {
                        Order order = (Order)orders[i];
                        Agent agent = (Agent)agents[j];
                        
                        hours += find_service(order).Duration;
                        if(hours > 40 || !agent.ServiceCodes.Contains(order.ServiceCode))
                        {
                            Console.WriteLine("Agent: " + agent.Name + " Hours: " + hours + " Service: " + order.ServiceCode);
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
                if (infinite_fitness(individual))
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
                        int lenght = random.Next(agents.Count);
                        individual[i] = (Agent)agents[lenght];
                    }
                    
                }
                individual = check_distribution(individual);
            }
        }

       
    }
}
