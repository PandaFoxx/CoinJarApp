# .NET Technical Assessment

## Part 1: Implement a coin jar in C#.
The coin jar will only accept the latest US coinage and has a volume of 42 fluid ounces. Additionally, the jar has a
counter to keep track of the total amount of money collected and can reset the count back to $0.00.
Interfaces
```
public interface ICoinJar
{
  void AddCoin(ICoin coin);
  decimal GetTotalAmount();
  void Reset();
}

public interface ICoin
{
  decimal Amount { get; set; }
  decimal Volume { get; set; }
}
```

## Part 2: Implement an API
Now that we have built a CoinJar, we could expose its functionality as a RESTful API.
Implement a RESTful API that exposes 3 endpoints which will allow us to do the following:
1. Add a coin.
2. Get the total amount of our coins.
3. Reset the coins.
With regards to data-persistence, you may use any approach you feel sufficiently demonstrates your
understanding of a RESTful API and its operations. This question is less about databases than it is about the API
surface itself. Some examples for the “database” might include:
- A singleton
- An in-memory cache
- A file on disk
- Mocks
- An actual database

## Test Submission
If possible, submit your source to a public SCM host (Preferably Git based) and provide Global Kinetic
with access details and documentation on how to run your project(s).
Assessment will be based on:
o Meeting the requirements specified.
o Proficiency using the required technologies & best practices.
o SCM usage.
o Documentation (if any, can be in simple markdown format).

