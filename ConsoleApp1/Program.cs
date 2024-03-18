// Perfect number from 0 to 10,000
/*
limit = 10000
sum = 0
for number in range(1, limit):
    for subNumber in range(1, limit -1):
        if number % subNumber == 0:
            sum += subNumber
    if sum == number:
        print(number)
 */
/*
int numberLimit = 10000;
for (int number = 1; number < numberLimit; number++) {
    int sum = 0;
    for (int subNumber = 1 ; subNumber < number; subNumber++) {
        if (number % subNumber == 0) {
            sum += subNumber;
        }
    }
    if (sum == number) {
        Console.WriteLine("{0}", number);
    }
}
*/

// Fibonacci numbers series
/* PYTHON approach
limit = 20
numbers = [0, 1]
for count in range(limit):
    if len(numbers) <= count:
        numbers += [numbers[-1] + numbers[-2]]
    print(numbers[count])
 */
/*
Console.Write("Enter a number limit: ");
int number = int.Parse(Console.ReadLine());
int previousNumber = 0;
int currentNumber = 1;
for (int count=0; count<number;count++) {
    if (count == 0) {
        Console.WriteLine("0");
        continue;
    } else if (count == 1) {
        Console.WriteLine("1");
        continue;
    }
    else {
        int newNumber = previousNumber + currentNumber;
        previousNumber = currentNumber;
        currentNumber = newNumber;
        Console.WriteLine(newNumber);
    }
}
*/

// factorial number
/* PYTHON
limit = 10 // user input
def fact(number):
    if number == 1:
        return 1
    else:
        return number * fact(number -1)
print(fact(10))
 */
/*
Console.Write("Enter a number limit: ");
int limit = int.Parse(Console.ReadLine());
int number = limit;
for (int count = limit - 1; count > 1; count--)
{
    number *= count;
}
Console.Write(number);
*/