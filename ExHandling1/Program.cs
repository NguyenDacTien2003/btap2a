using System;
using System.Collections.Concurrent;
using System.Text;
namespace Bai05
{
    class vidu1
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[5];
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("a[{0}] = ", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Khong duoc nhap ki tu so");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Khong duoc nhap gia trij nam ngoai 0-225");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("loi vuot qua vi pham");
            }
            for(int i = 0; i < 5; i++)
                Console.WriteLine("{0}", a[i]);
        }

            }
        }
   