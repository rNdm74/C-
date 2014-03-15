
        private void loadCritterList()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(inputFileName);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Can't find the input file!");
            }

            if (sr != null)
            {
                String currentLine = "";
                String[] currentAnimal;

                while ((currentLine = sr.ReadLine()) != null)
                {
                    currentAnimal = currentLine.Split(',');

                    ESpecies currentSpecies = (ESpecies)System.Enum.Parse(typeof(ESpecies), currentAnimal[1]);
                    critterList.Add(new Critter(currentAnimal[0], currentSpecies));
                } // end for each line
            } // end if sr != null
        } // end loadCritterList
  