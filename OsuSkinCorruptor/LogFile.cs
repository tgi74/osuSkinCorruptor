using System.Collections.Generic;
using System.IO;

namespace OsuSkinCorruptor
{
    static class LogFile
    {

        public static void write(string[] values)
        {
            File.WriteAllLines("obsCapture.txt", getContentFromValues(values));
        }

        private static string[] getContentFromValues(string[] values)
        {

            string skinName = values[0];
            bool corruptTextures = bool.Parse(values[1]);
            bool corruptSounds = bool.Parse(values[2]);
            string seed = values[3];
            bool corruptSkinFile = bool.Parse(values[4]);
            bool resetCursor = bool.Parse(values[5]);
            int power = int.Parse(values[6]);

            List<string> content = new List<string>();

            content.Add("skin: " + skinName);

            content.Add("seed: " + seed);

            content.Add("power: " + power);

            if (corruptTextures)
                content.Add("Corrupting textures");

            if (corruptSounds)
                content.Add("Corrupting sounds");

            if (corruptSkinFile)
                content.Add("Corrupting skin.ini");

            return content.ToArray();
        }
    }
}
