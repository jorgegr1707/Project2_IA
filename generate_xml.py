from random import randint
from random import seed
from random import sample


agent_first_names = ["Estelle", "Joy", "Charlotte", "Luz", "Clay"
                     ,"Samantha", "Raymond", "Johanna", "Madeline", "Lawrence"
                     ,"Jeffrey", "Cindy", "Joanna", "Jamie", "Chester"
                     ,"Susie", "Tommy", "Terrance", "Jessie", "Rudy"]

agent_last_names = ["Figueroa", "Bridges", "Caldwell", "Nash", "Vega"
                    ,"Page", "Hale", "Salazar", "Terry", "Lynch"
                    ,"Doyle", "Cummings", "Lamb", "Marsh", "Fletcher"
                    ,"Ruiz", "Norris", "Rose", "Fuller", "Hanson"]

client_first_names = ["Ora", "Kent", "Verona", "Giovanni", "Janelle"
                      ,"Kizzie","Edison","Yuri", "Rubin","Carry"
                      ,"Desmond", "Denis","Phillip","Layla","Carmel"
                      ,"Evonne", "Lakiesha","Robyn", "Jeremiah","Byron"]

client_last_names = ["Estrada", "Arias", "Swanson", "Diaz", "Nelson"
                     , "Beck", "Lynn", "Arellano", "Espinoza", "Adams"
                     ,"Daniels", "Roth", "Luna", "Horton", "Parks"
                     ,"Patton", "Anthony", "Potter", "Bauer", "Grimes"]

service_codes = ["ICE", "ICG", "ILA", "RCE", "RCG", "RLA"]


file_agents = open("agents.xml", "w+")
file_orders = open("orders.xml", "w+")

file_agents.write("<agents>\n")
#Create agents
for i in range(50):
    file_agents.write("\t<agent>\n")

    file_agents.write("\t\t<id>" + str(i+1) + "</id>\n")
    file_agents.write("\t\t<name>" + agent_first_names[randint(0,19)]
                      + " " + agent_last_names[randint(0,19)] + "</name>\n")
    file_agents.write("\t\t<service_codes>\n")

    services_agent = sample(range(6), randint(1,6))
    services_agent.sort()
    for i in services_agent:
        file_agents.write("\t\t\t<code>"+service_codes[i]+"</code>\n")
        

    file_agents.write("\t\t</service_codes>\n")
    file_agents.write("\t</agent>\n")

file_agents.write("</agents>")


#Create orders


file_orders.write("<orders>\n")
for i in range(100):
    file_orders.write("\t<order>\n")
    file_orders.write("\t\t<id>"+ str(i+1) +"</id>\n")
    file_orders.write("\t\t<client>" + client_first_names[randint(0,19)]
                      + " " + client_last_names[randint(0,19)] + "</client>\n")
    file_orders.write("\t\t<service>" + service_codes[randint(0,5)] + "</service>\n")
    file_orders.write("\t</order>\n")

file_orders.write("</orders>")


file_orders.close()
file_agents.close()
