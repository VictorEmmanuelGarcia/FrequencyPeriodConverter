using System;

class TimeFrequencyConverter
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Time to Frequency Conversion");
            Console.WriteLine("2. Frequency to Time Conversion");
            Console.WriteLine("3. Exit");
            Console.WriteLine("");
            Console.Write("Enter input: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    TimeToFrequencyMenu();
                    break;

                case 2:
                    FrequencyToTimeMenu();
                    break;

                case 3:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }

    static void TimeToFrequencyMenu()
    {
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Choose a time unit for conversion:");
            Console.WriteLine("1. Seconds");
            Console.WriteLine("2. Milliseconds");
            Console.WriteLine("3. Microseconds");
            Console.WriteLine("4. Nanoseconds");
            Console.WriteLine("5. Picoseconds");
            Console.WriteLine("6. Back to main menu");
            Console.WriteLine("");
            Console.Write("Enter input: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter time in seconds: ");
                    double time = double.Parse(Console.ReadLine());
                    double frequency = ConvertTimeToFrequency(time);
                    Console.WriteLine("");
                    Console.WriteLine($"Frequency: {frequency} Hz");
                    Console.WriteLine("");
                    break;

                case 2:
                    Console.Write("Enter time in milliseconds: ");
                    double timeInMilliseconds = double.Parse(Console.ReadLine());
                    double frequencyInMillis = ConvertTimeToFrequency(timeInMilliseconds / 1000.0); // Convert milliseconds to seconds
                    Console.WriteLine("");
                    Console.WriteLine($"Frequency: {frequencyInMillis} Hz");
                    Console.WriteLine("");
                    break;

                case 3:
                    Console.Write("Enter time in microseconds: ");
                    double timeInMicroseconds = double.Parse(Console.ReadLine());
                    double frequencyInMicros = ConvertTimeToFrequency(timeInMicroseconds / 1_000_000.0); // Convert microseconds to seconds
                    Console.WriteLine("");
                    Console.WriteLine($"Frequency: {frequencyInMicros} Hz");
                    Console.WriteLine("");
                    break;

                case 4:
                    Console.Write("Enter time in nanoseconds: ");
                    double timeInNanoseconds = double.Parse(Console.ReadLine());
                    double frequencyInNanos = ConvertTimeToFrequency(timeInNanoseconds / 1_000_000_000.0); // Convert nanoseconds to seconds
                    Console.WriteLine("");
                    Console.WriteLine($"Frequency: {frequencyInNanos} Hz");
                    Console.WriteLine("");
                    break;

                case 5:
                    Console.Write("Enter time in picoseconds: ");
                    double timeInPicoseconds = double.Parse(Console.ReadLine());
                    double frequencyInPicos = ConvertTimeToFrequency(timeInPicoseconds / 1_000_000_000_000.0); // Convert picoseconds to seconds
                    Console.WriteLine("");
                    Console.WriteLine($"Frequency: {frequencyInPicos} Hz");
                    Console.WriteLine("");
                    break;

                case 6:
                    return; // Return to the main menu

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    Console.WriteLine("");
                    break;
            }
        }
    }

    static void FrequencyToTimeMenu()
    {
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Choose a frequency unit for conversion:");
            Console.WriteLine("1. Hertz");
            Console.WriteLine("2. Kilohertz");
            Console.WriteLine("3. Megahertz");
            Console.WriteLine("4. Gigahertz");
            Console.WriteLine("5. Terahertz");
            Console.WriteLine("6. Back to main menu");
            Console.WriteLine("");
            Console.Write("Enter input: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("");
                    Console.Write("Enter frequency in Hertz: ");
                    double frequency = double.Parse(Console.ReadLine());
                    double time = ConvertFrequencyToTime(frequency);
                    Console.WriteLine("");
                    Console.WriteLine($"Time: {time} seconds");
                    Console.WriteLine("");
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.Write("Enter frequency in Kilohertz: ");
                    double frequencyInKilohertz = double.Parse(Console.ReadLine());
                    double timeInKiloseconds = ConvertFrequencyToTime(frequencyInKilohertz * 1000.0); // Convert kilohertz to hertz
                    Console.WriteLine("");
                    Console.WriteLine($"Time: {timeInKiloseconds} seconds");
                    Console.WriteLine("");
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.Write("Enter frequency in Megahertz: ");
                    double frequencyInMegahertz = double.Parse(Console.ReadLine());
                    double timeInMegaseconds = ConvertFrequencyToTime(frequencyInMegahertz * 1_000_000.0); // Convert megahertz to hertz
                    Console.WriteLine("");
                    Console.WriteLine($"Time: {timeInMegaseconds} seconds");
                    Console.WriteLine("");
                    break;

                case 4:
                    Console.WriteLine("");
                    Console.Write("Enter frequency in Gigahertz: ");
                    double frequencyInGigahertz = double.Parse(Console.ReadLine());
                    double timeInGigaseconds = ConvertFrequencyToTime(frequencyInGigahertz * 1_000_000_000.0); // Convert gigahertz to hertz
                    Console.WriteLine("");
                    Console.WriteLine($"Time: {timeInGigaseconds} seconds");
                    Console.WriteLine("");
                    break;

                case 5:
                    Console.WriteLine("");
                    Console.Write("Enter frequency in Terahertz: ");
                    double frequencyInTerahertz = double.Parse(Console.ReadLine());
                    double timeInTeraseconds = ConvertFrequencyToTime(frequencyInTerahertz * 1_000_000_000_000.0); // Convert terahertz to hertz
                    Console.WriteLine("");
                    Console.WriteLine($"Time: {timeInTeraseconds} seconds");
                    Console.WriteLine("");
                    break;

                case 6:
                    Console.WriteLine("");
                    return; // Return to the main menu

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    Console.WriteLine("");
                    break;
            }
        }
    }

    // Function to convert time to frequency (in seconds)
    static double ConvertTimeToFrequency(double time)
    {
        if (time == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("Time cannot be zero.");
            return 0;
        }
        return 1.0 / time;
    }

    // Function to convert frequency to time (in seconds)
    static double ConvertFrequencyToTime(double frequency)
    {
        if (frequency == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("Frequency cannot be zero.");
            return 0;
        }
        return 1.0 / frequency;
    }
}
