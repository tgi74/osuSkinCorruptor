using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OsuSkinCorruptor
{
    class Corruptor
    {
        string skinUrl;
        string corruptedSkinUrl;
        int seed;
        int power;
        Random r;

        public bool corruptTextures = false;
        public bool corruptSounds = false;
        public bool corruptSkinFile = false;
        public bool resetCursorFiles = false;
        public bool keepBigtextures = false;

        public Corruptor(string skinUrl, int seed, int power)
        {
            this.skinUrl = skinUrl;
            this.seed = seed;
            this.power = power;
            corruptedSkinUrl = Directory.GetParent(skinUrl) + @"\corrupted\";
            r = new Random(seed);
        }

        private void setup()
        {
            LogFile.write(new string[] { new DirectoryInfo(skinUrl).Name, corruptTextures.ToString(), corruptSounds.ToString(), seed.ToString(), corruptSkinFile.ToString(), keepBigtextures.ToString(), power.ToString() });

            if (Directory.Exists(corruptedSkinUrl))
                Directory.Delete(corruptedSkinUrl, true);

            Directory.CreateDirectory(corruptedSkinUrl);
        }

        private void shuffleSkinFileValues(string fileUrl)
        {

            string[] text = File.ReadAllLines(fileUrl);
            List<string> newtext = new List<string>();

            foreach(string s in text)
            {
                string[] ss = s.Split(':');
                if (ss.Length == 1 || (ss[0] == "CursorCentre" && resetCursorFiles))
                {
                    newtext.Add(s);
                    continue;
                }

                // Check if color

                string[] sss = ss[1].Split(',');
                if(sss.Length == 3)
                {
                    newtext.Add(ss[0] + ": " + r.Next(0, 256)+","+ r.Next(0, 256) +","+ r.Next(0, 256));
                    continue;
                }

                //Check if int

                int result;
                if(int.TryParse(ss[1], out result))
                {

                    if (result == 0)
                        result = r.Next(0, 2);
                    else
                        result = r.Next(0, result);

                    newtext.Add(ss[0] + ": " + result);
                    continue;
                }

            }

            File.WriteAllLines(fileUrl, newtext);

        }

        private void shuffleFromExtension(string extension)
        {
            List<string> images = new List<string>();
            foreach (string path in Directory.GetFiles(skinUrl, extension, SearchOption.TopDirectoryOnly))
            {
                images.Add(Path.GetFileName(path));
            }

            //Randomize textures
            images = shuffle(images);
            int id = -1;
            foreach (string s in Directory.GetFiles(skinUrl, extension, SearchOption.TopDirectoryOnly))
            {
                id++;
                if (images.Count == id) break;

                if(extension == "*.png" && keepBigtextures)
                {
                    Bitmap b = new Bitmap(s);
                    if (b.Width >= 128)
                    {
                        b.Dispose();
                        continue;
                    }
                    b.Dispose();
                }
                File.Copy(s, corruptedSkinUrl + images[id]);
            }
        }

        private void resetCursor()
        {
            string[] names = new string[] { "cursor.png", "cursormiddle.png", "cursortrail.png", "star2.png" };
            
            foreach(string s in names)
            {
                string url = corruptedSkinUrl + s;
                if (File.Exists(url))
                    File.Delete(url);
            }

        }

        private void completeFiles()
        {
            foreach (string s in Directory.GetFiles(skinUrl, "*.*", SearchOption.TopDirectoryOnly))
            {
                if (!File.Exists(corruptedSkinUrl + Path.GetFileName(s)))
                    File.Copy(s, corruptedSkinUrl + Path.GetFileName(s), false);
            }
        }

        public void start()
        {
            setup();

            if(corruptTextures)
                shuffleFromExtension("*.png");

            if(corruptSounds)
                shuffleFromExtension("*.wav");

            completeFiles();

            if (corruptSkinFile)
                shuffleSkinFileValues(corruptedSkinUrl + "skin.ini");

            if (resetCursorFiles)
                resetCursor();

            MessageBox.Show("Skin corrupted !");
        }

        /// <summary>
        /// Randomize the content of a given List
        /// </summary>
        /// <typeparam name="E">Type to the List</typeparam>
        /// <param name="inputList">List that will be randomized</param>
        /// <returns>shuffled list</returns>
        private List<E> shuffle<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();

            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count);
                if(r.Next(0, 101) <= power)
                    randomList.Add(inputList[randomIndex]);
                inputList.RemoveAt(randomIndex);
            }

            return randomList;
        }

    }
}
