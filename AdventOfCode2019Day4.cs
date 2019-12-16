
        //only part one is in C#
        static int TotalCombinations()
        {
            int min = 372304;
            int max = 847060;
            int numOfCombinatios = 0;

            for(int i = min; i < max + 1; i++)
            {
                char prev = i.ToString()[0];
                int pairs = 0;
                foreach(char c in i.ToString().Skip(1))
                {
                    if (prev > c)
                    {
                        pairs = 0;
                        break;
                    }
                        
                    if (prev == c)
                        pairs++;

                    prev = c;
                }

                if (pairs > 0)
                    numOfCombinatios++;
            }

            return numOfCombinatios;
        }
