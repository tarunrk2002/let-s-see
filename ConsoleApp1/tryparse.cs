using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tryparse
    {
        public async void parsee()
        {
            //string a = "hjh";
            //int b;
            //int.TryParse(a, out b);
            //Console.WriteLine(b);

            string[] frame1 = new string[]  {@"            ",
                                  @"   O    O   ",
                                  @"     /\     ",
                                  @"    ----    ",
                                };

            string[] frame2 = new string[] { @"            ",
                                  @"   O    o   ",
                                  @"     /\     ",
                                  @"    ----    ",
                                };

            string[] frame3 = new string[] { @"            ",
                                  @"   O    -   ",
                                  @"     /\     ",
                                  @"     --     ",
                                };

            string[] frame4 = new string[] { @"            ",
                                  @"   O    o   ",
                                  @"     /\     ",
                                  @"    ----    ",
                                };

            string[][] frames = new string[][] { frame1, frame2, frame3, frame4 };

            Console.CursorVisible = false;

            await Animate(frames);

            Console.WriteLine("Finished");

            Console.CursorVisible = true;

            async Task Animate(string[][] frames)
            {
                Console.Clear();

                while (Console.KeyAvailable is false)
                {
                    foreach (var frame in frames)
                    {
                        foreach (var line in frame)
                        {
                            Console.WriteLine(line);
                        }
                        await Task.Delay(300);
                        Console.CursorTop = 0;
                    }
                }
            }
        }
    }
}
