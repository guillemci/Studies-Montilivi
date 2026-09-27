double pessetes, euros;

Console.Write("Introdueix numero en euros: ");

euros = Convert.ToDouble(Console.ReadLine());

pessetes = euros * 166.386;

Console.WriteLine($"Aquest numero d'euros {euros} equivalen a aquestes pessetes {pessetes:F2}");