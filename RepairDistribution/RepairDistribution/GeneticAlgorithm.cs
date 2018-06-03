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
        int cant_individuals;
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
            cant_individuals = 10;
            mutation_percent = 0.02;
        }

        //initial population
        public void generate_population()
        {
            for (int i = 0; i < cant_individuals; i++)
            {
                List<Agent> individual = new List<Agent>();
                for (int j = 0; j < orders.Count; j++)
                {
                    individual.Add(agents[random.Next(agents.Count)] as Agent);

                }
                individual = check_distribution(individual);
                individual = redistribute_agents(individual);
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

        public List<Agent> find_agents_by_service(string service_code)
        {
            List<Agent> agents_by_service = new List<Agent>();
            foreach(Agent agent in agents)
            {
                if(agent.ServiceCodes.Contains(service_code))
                {
                    agents_by_service.Add(agent);
                }
            }
            return agents_by_service;
        }

        public List<Agent> redistribute_agents(List<Agent> individual)
        {
            for (int i = 0; i < individual.Count; i++)
            {
                Order order = (Order)orders[i];
                Agent agent = (Agent)individual[i];
                List<Agent> agents_by_service = find_agents_by_service(order.ServiceCode); //this list has the agents that can do this service
                if (!agent.ServiceCodes.Contains(order.ServiceCode))//if this agent can´t do this service we have to change it with amother agent that can do it
                {
                    Agent swap = agents_by_service[random.Next(agents_by_service.Count)];//agent to replace the agent that can't do the service
                    int index_swap = individual.IndexOf(swap);
                    //make swap with this two agents
                    individual[i] = swap;
                    individual[index_swap] = agent;
                }
            }
            return individual;
        }

        //calculate commission for every agent
        public List<int> commission_agents(List<Agent> individual)
        {
            List<int> commissions = new List<int>();
            for(int i = 0; i < agents.Count; i++)
            {
                int sum = 0;
                for (int j = 0; j < individual.Count; j++)
                {
                    if (agents[i].Equals(individual[j]))
                    {
                        Order order = (Order)orders[j];
                        sum += find_service(order).Commission;
                    }
                }
                
                commissions.Add(sum);
            }
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


        public void calculate_fitness()
        {
            foreach(List<Agent> individual in population)
            {
                fitness.Add(variance(commission_agents(individual)));
                
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
                individual = redistribute_agents(individual);
            }
        }

       
    }
}
