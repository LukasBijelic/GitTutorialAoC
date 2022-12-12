string input = File.ReadAllText("input01.txt");

int maxCalories = input.Split("\r\n\r\n")
    .Max(elf =>
    elf.Split("\n", StringSplitOptions.RemoveEmptyEntries)
    .Sum(int.Parse)
    );
Console.WriteLine($"Part 1: {maxCalories}");