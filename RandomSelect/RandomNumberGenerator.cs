using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandomSelect
{
    class RandomNumberGenerator
    {
        private readonly int MAX_SEED_INDEX = 10;
        private int seedIndex = 0;
        private int[] seedArray;

        public enum GenerateMode
        {
            Security,
            Seed,
            Time
        }
        public GenerateMode generateMode = GenerateMode.Security;

        public RandomNumberGenerator(string[] seedStringArray)
        {
            if (seedStringArray.Count() == 0)
                seedStringArray = new string[] { string.Empty };
            MAX_SEED_INDEX = seedStringArray.Count();
            seedArray = new int[seedStringArray.Count()];
            for(int i=0; i<seedStringArray.Count(); i++)
            {
                foreach (char seedString in seedStringArray[i])
                    seedArray[i] = seedArray[i] ^ Convert.ToByte(seedString);
            }
        }

        public int Generate(int min, int max)
        {
            switch(generateMode)
            {
                case GenerateMode.Security :
                    return GenerateBySecurity(min, max);
                case GenerateMode.Seed :
                    return GenerateByTimeAndSeed(min, max);
                case GenerateMode.Time:
                    return GenerateByTime(min, max);
                default:
                    return GenerateBySecurity(min, max);
            }
        }

        public int GenerateByTime(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max + 1);
        }

        public int GenerateByTimeAndSeed(int min, int max)
        {
            if (min == max)
                return min;
            else if (min > max)
                return min;

            var random = new Random();
            var randomGenerateByTime = random.Next(max);

            random = new Random(seedArray[seedIndex]);
            seedIndex = (seedIndex + 1) % MAX_SEED_INDEX;
            var randomGeneratedBySeed = random.Next(max);

            return (randomGenerateByTime + randomGeneratedBySeed) % (max - min + 1) + min;
        }

        public int GenerateBySecurity(int min, int max)
        {
            if (min == max)
                return min;
            else if (min > max)
                return min;

            int result = 0;
            int count = 0;
            while(result == 0)
            {
                RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                var byteArray = new byte[4];
                provider.GetBytes(byteArray);

                //convert 4 bytes to an integer
                result =  Math.Abs(BitConverter.ToInt32(byteArray, 0));
                if (++count == 5)
                {
                    result = int.MaxValue;
                    break;
                }
            }

            return result % (max - min + 1) + min;
        }
    }
}
