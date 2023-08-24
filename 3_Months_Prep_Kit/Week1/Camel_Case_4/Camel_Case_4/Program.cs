static void Main()
{

    bool moreInput = true;
    List<String> inputs = new List<String>();

    do
    {

        String input = Console.ReadLine();
        if (input == null || input.Equals("exit") || input.Equals("") || input.Equals(" "))
        {
            break;
        }

        
        
        inputs.Add(input);

    } while (moreInput);

   foreach (String arg in inputs)
    {
        string operationMode = arg.Substring(0, 1);
        string type = arg.Substring(2, 1);
        string name = arg.Substring(4);
        char[] delimiter = new char[] { ' ' };
        if (operationMode.Equals("S"))
        {
            //SPLIT MODE

            //PARENTHESES REMOVER
            if(type.Equals("M")) 
            {
                name = name.Substring(0, name.Length - 2);
            }

            //SPACE ADDER
            int index = 0;
            String nameTemp = "";
            foreach (char c in name)
            {
                if(Char.IsUpper(c) && index != 0) 
                {

                    nameTemp += " ";

                }

                nameTemp += c;
                index++;
            }

            name = nameTemp.ToLower();
            Console.WriteLine(name);

        }

        else
        {
            //COMBINE MODE

            //SPACE REMOVER
            String nameTemp = "";
            for (int index = 0; index < name.Length; index++)
            {


                //UPPERCASE TO CLASS
                if (index == 0 && type.Equals("C"))
                {
                    nameTemp+= Char.ToUpper(name[0]);
                    index++;
                }


                if (name[index].Equals(' '))
                {
                    char temp = name[index + 1];
                    temp = Char.ToUpper(temp);
                    nameTemp += temp;
                    index++;
                }

                else
                {
                    nameTemp += name[index];
                }

                
            }

            //PARENTHESES ADDER
            if (type.Equals("M"))
            {
                nameTemp += "()";
            }

            

            Console.WriteLine(nameTemp);


        }
    }
}


Main();