namespace NumberSerie
    {
        class Program
        {
            static void Main(string[] args)
            {
                int userNumber = 0;
                string seriesOption = "";
                bool isValidInput = false;

                // Step 2: Ask the user to enter an integer value between 1 and 100.
                while (!isValidInput)
                {
                    try
                    {
                        Console.WriteLine("Please enter an integer value between 1 and 100:");
                        userNumber = Convert.ToInt32(Console.ReadLine());

                        if (userNumber < 1 || userNumber > 100)
                        {
                            throw new ArgumentException("The number must be between 1 and 100.");
                        }

                        isValidInput = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Invalid input: {ex.Message}");
                    }
                }

                isValidInput = false;

                // Step 3: Ask the user to specify a series of integer numbers (even or odd).
                while (!isValidInput)
                {
                    try
                    {
                        Console.WriteLine("Please specify a series of integer numbers. Type 'even' for even numbers or 'odd' for odd numbers:");
                    seriesOption = Console.ReadLine()?.ToLower() ?? "";

                    if (seriesOption != "even" && seriesOption != "odd")
                        {
                            throw new ArgumentException("Please type 'even' or 'odd'.");
                        }

                        isValidInput = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Invalid input: {ex.Message}");
                    }
                }

                // Step 4 & 5: Display the message and numbers from the series.
                Console.WriteLine($"You have selected the {seriesOption} series. The numbers between 0 and {userNumber} are:");

                int i = (seriesOption == "even") ? 0 : 1;

                while (i <= userNumber)
                {
                    Console.Write(i + " ");
                    i += 2;
                }
            }
        }
    }
