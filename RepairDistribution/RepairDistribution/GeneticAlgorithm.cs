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
        List<List<Agent>> new_population;
        List<float> fitness;
        int limit_gens;  //limit of generations
        int cant_individuals;
        int punishment;
        Double mutation_percent;
        Random random = new Random();

        public GeneticAlgorithm(ArrayList agents, ArrayList orders, ArrayList services)
        {
            this.agents = agents;
            this.orders = orders;
            this.services = services;
            population = new List<List<Agent>>();
            new_population = new List<List<Agent>>();
            fitness = new List<float>();
            limit_gens = 500;
            cant_individuals = 100;
            punishment = 1000;
            mutation_percent = 0.02;
        }

        //initial population
        public void generate_population()
        {
            for (int i = 0; i < cant_individuals; i++)
            {
                List<Agent> individual = new List<Agent>();
                foreach(Order order in orders)
                {
                    individual.Add(get_agent(individual, order.ServiceCode));
                }
                population.Add(individual);

            }
            calculate_fitness();

            /*Debug part
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

        /*//check if every agent has a order (minimum)
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
        }*/

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

       /* public List<Agent> redistribute_agents(List<Agent> individual)
        {
            for (int i = 0; i < individual.Count; i++)
            {
                Order order = (Order)orders[i];
                Agent agent = (Agent)individual[i];
                List<Agent> agents_by_service = find_agents_by_service(order.ServiceCode);  //this list has the agents that can do this service
                if (!agent.ServiceCodes.Contains(order.ServiceCode))  //if this agent can´t do this service we have to change it with amother agent that can do it
                {
                    Agent swap = agents_by_service[random.Next(agents_by_service.Count)];  //agent to replace the agent that can't do the service
                    int index_swap = individual.IndexOf(swap);
                    //make swap with this two agents
                    individual[i] = swap;
                    individual[index_swap] = agent;
                }
            }
            return individual;
        }*/

        public List<Agent> agents_not_busy(List<Agent> individual)
        {
            List<Agent> list_agents = new List<Agent>();
            foreach(Agent agent in agents)
            {
                if (!individual.Contains(agent))
                {
                    list_agents.Add(agent);
                }
            }
            return list_agents;
        }
        public List<Agent> agents_by_service_individual(List<Agent> agents_services, List<Agent> agents_without_job)
        {
            List<Agent> agents_priority = new List<Agent>();
            foreach(Agent agent in agents_without_job)
            {
                if(agents_services.Contains(agent))
                {
                    agents_priority.Add(agent);
                }
            }
            return agents_priority;
        }
        public Agent get_agent(List<Agent> individual, string service_code)
        {
            List<Agent> agents_without_job = agents_not_busy(individual);
            List<Agent> agents_by_service = find_agents_by_service(service_code);

            List<Agent> agents_with_priority = agents_by_service_individual(agents_by_service, agents_without_job);
            Agent agent;
            if(agents_by_service.Count == 0)
            {
                return null;
            }

            if(agents_with_priority.Count == 0)
            {
				int value = random.Next(agents_by_service.Count);
				agent = agents_by_service[value] as Agent;
            }
            else
            {
                agent = agents_with_priority[random.Next(agents_with_priority.Count)] as Agent;
            }
            return agent;
        }

        //calculate commission for every agent
        public List<List<int>> commission_and_hours_agents(List<Agent> individual)
        {
            List<int> commissions = new List<int>();
            List<int> hours = new List<int>();
            List<List<int>> result = new List<List<int>>();
            for(int i = 0; i < agents.Count; i++)
            {
                int sum = 0;
                int hour = 0;
                for (int j = 0; j < individual.Count; j++)
                {
                    if (agents[i].Equals(individual[j]))
                    {
                        Order order = (Order)orders[j];
                        sum += find_service(order).Commission;
                        hour += find_service(order).Duration;
                    }
                }
                
                commissions.Add(sum);
                hours.Add(hour);
            }
            result.Add(commissions);
            result.Add(hours);
            return result;
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

        public int get_punishment(List<int> hours)
        {
            int cant = 0;
            foreach(int hour in hours)
            {
                if (hour > 40)
                {
                    cant += 1;
                }
            }
            return cant;
        }

        public void calculate_fitness()
        {
            fitness = new List<float>();
            foreach(List<Agent> individual in population)
            {
                List<List<int>> var = commission_and_hours_agents(individual);
                float punish = (float)get_punishment(var.ElementAt(1));
                float fitness_individual = variance(var.ElementAt(0)) + (punish * punishment);
                fitness.Add(fitness_individual);
            } 
        }

        public void mutate_after_creation(List<Agent> individual)
        {
            for (int i = 0; i < individual.Count; i++)
            {
                double random_mutate = (Double)(random.Next(100) / 100);
                if (random_mutate < mutation_percent)
                {
                    Order order = (Order) orders[i];
                    individual[i] = get_agent(individual, order.ServiceCode);
                    
                }
            }
            new_population.Add(individual);

        }

        public List<Agent> tournament_selection()
        {
            int index = random.Next(population.Count - 1);
            int count = random.Next(1, population.Count - index);
            List<float> random_sample = fitness.GetRange(index, count);
            int best = random_sample.IndexOf(random_sample.Min());
            best += index; //real position
            return population[best];
        }

        public void crossover(List<Agent> father, List<Agent> mother)
        {
            int index = random.Next(1, father.Count - 2);
            List<Agent> child_one = new List<Agent>();
            List<Agent> child_two = new List<Agent>();
            for (int i = 0; i < index; i++)
            {
                child_one.Add(father[i]);
                child_two.Add(mother[i]);
            }
            for(int j = index; j < father.Count; j++)
            {
                child_one.Add(mother[j]);
                child_two.Add(father[j]);
            }
            mutate_after_creation(child_one);
            mutate_after_creation(child_two);
        }

        public void create_new_population()
        {
            for (int i = 0; i < population.Count / 2; i++)
            {
                List<Agent> father = tournament_selection();
                List<Agent> mother = tournament_selection();
                crossover(father, mother);
            }
            population = new_population;
            new_population = new List<List<Agent>>();
            calculate_fitness();
            
        }

        public List<Agent> get_solution()
        {
            generate_population();
            for(int i = 0; i < limit_gens; i++)
            {
                if(fitness.Contains(0))
                {
                    return population.ElementAt(fitness.IndexOf(0));
                }
                else
                {
                    create_new_population();   
                }
            }
            return population[fitness.IndexOf(fitness.Min())];
        }
       
    }
}
