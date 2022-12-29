﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce205_hw4_gui
{
    public class Knuth_Morris_Pratt
    {
        /// <summary>
        /// This method is used to find the longest prefix which is also a suffix
        /// </summary>
        /// <param name="pat"></param>
        /// <param name="txt"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public int KMPSearch(string pat, string txt, int startIndex)
        {
            int M = pat.Length;
            int N = txt.Length;

            /*
             * create lps[] that will hold the longest prefix suffix
             * values for pattern
             */
            int[] lps = new int[M];
            /*
             * index for pat[]
             */
            int j = 0;

            /*
             * Preprocess the pattern (calculate lps[] array)
             */
            computeLPSArray(pat, M, lps);

            /*
             * index for txt[]
             */
            int i = startIndex;
            while (i < N)
            {
                if (pat[j] == txt[i])
                {
                    j++;
                    i++;
                }
                if (j == M)
                {
                    return i - j;
                }

                /*
                 * mismatch after j matches
                 */
                else if (i < N && pat[j] != txt[i])
                {
                    /*
                     * Do not match lps[0..lps[j-1]] characters,
                     * they will match anyway
                     */
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }
            /*
             * we reach here only when pat[] is not present in txt[]
             */
            return -1;
        }
        /// <summary>
        /// This method is used to compute the longest prefix which is also a suffix
        /// </summary>
        /// <param name="pat"></param>
        /// <param name="M"></param>
        /// <param name="lps"></param>
        public void computeLPSArray(string pat, int M, int[] lps)
        {
            /*
             * length of the previous longest prefix suffix
             */
            int len = 0;
            int i = 1;
            lps[0] = 0; // lps[0] is always 0

            /*
             * the loop calculates lps[i] for i = 1 to M-1
             */
            while (i < M)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else // (pat[i] != pat[len])
                {
                    /*
                     * This is tricky. Consider the example.
                     * AAACAAAA and i = 7. The idea is similar 
                     * to search step.
                     */
                    if (len != 0)
                    {
                        len = lps[len - 1];

                        /*
                         * Also, note that we do not increment
                         * i here
                         */
                    }
                    /*
                     * if (len == 0)
                     */
                    else
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
    }
}
    

