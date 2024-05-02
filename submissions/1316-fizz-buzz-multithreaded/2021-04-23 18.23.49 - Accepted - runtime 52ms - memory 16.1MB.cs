public class FizzBuzz {
    private int n;

    public FizzBuzz(int n) {
        this.n = n;
    }
    
    private int workingNumber = 1;
    private void WaitWorkingNumber(int v){
       // while(v < workingNumber)
       // {
            System.Threading.Thread.Sleep(5);
      //  }
    }

    // printFizz() outputs "fizz".
    public void Fizz(Action printFizz) {
        for (int i = 1; i <= n; i++)
        {
            WaitWorkingNumber(i);
            if (i % 3 == 0 && i % 5 != 0)
            {
                printFizz();
                workingNumber++;
            }
        }
    }

    // printBuzzz() outputs "buzz".
    public void Buzz(Action printBuzz) {
        for (int i = 1; i <= n; i++)
        {
            WaitWorkingNumber(i);
            if (i % 3 != 0 && i % 5 == 0)
            {
                printBuzz();
                workingNumber++;
            }
        }
    }

    // printFizzBuzz() outputs "fizzbuzz".
    public void Fizzbuzz(Action printFizzBuzz) {
        for (int i = 1; i <= n; i++)
        {
            WaitWorkingNumber(i);
            if (i % 3 == 0 && i % 5 == 0)
            {
                printFizzBuzz();
                workingNumber++;
            }
        }
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Number(Action<int> printNumber) {
        for (int i = 1; i <= n; i++)
        {
            WaitWorkingNumber(i);
            if (i % 3 != 0 && i % 5 != 0)
            {
                printNumber(i);
                workingNumber++;
            }
        }
    }
}