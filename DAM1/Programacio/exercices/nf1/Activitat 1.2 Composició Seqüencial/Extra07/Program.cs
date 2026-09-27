double pessetes, euros;

Console.Write("Introdueix numero en pessetes: ");
pessetes = Convert.ToDouble(Console.ReadLine());

euros = pessetes / 166.386;

Console.WriteLine($"Aquest numero de pessetes {pessetes} equivalen a aquests euros {euros:F2}");