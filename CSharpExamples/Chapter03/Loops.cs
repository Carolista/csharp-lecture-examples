namespace Chapter03
{
    public class Loops
    {
        public static void RunExamples()
        {
            /* FOR LOOP */

            string[] battles = {
                "The Battle of Moria",
                "The Battle for Isengard",
                "The Battle of Helm's Deep",
                "The Battle of the Pelennor Fields",
                "The Battle of the Black Gate"
            };

            // TODO: Construct a basic for loop to print each battle



            /* FOR-EACH LOOP */

            String[] words = {"YOU", "SHALL", "NOT", "PASS"};

            // TODO: Construct a for-each loop to print each element of the Array above


            /* FOR EACH LOOP WITH DICTIONARY */

            Dictionary<string, string> moria = new Dictionary<string, string>();

            // moria.put("name", "the Mines of Moria");
            // moria.put("ancientName", "Khazad-dûm");
            // moria.put("location", "the Misty Mountains");
            // moria.put("founder", "Durin");
            // moria.put("king", "Balin");
            // moria.put("monster", "a balrog");

            // TODO: Construct three for-each loops for the dictionary above

            // Loop through keys and print each

            // Loop through values and print each

            // Loop through key/value pairs and print them


            /* WHILE LOOP */

            int[] orcs = {2, 14, 33, 57, 61, 89, 94, 106, 123, 176};

            // TODO: Construct a while loop to print each number in the Array above as long as the value is below 100


            /* DO-WHILE LOOP */

            List<string> bookTitles = new List<string>();

            // TODO: Construct a do-while loop to ask the user for book titles until they enter "QUIT"
            // HINT: use .nextLine() instead of .next() to handle multi-word strings
            // Unless quitting, add each title to the collection above
            // Print the collection after the loop closes
        }
    }
}