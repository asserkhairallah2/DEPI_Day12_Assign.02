using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static TaskApp.ListGenerators;

namespace TaskApp
{
    internal class Program
    {
        static void Main()
        {
            string[] dictionaryWords = File.Exists("dictionary_english.txt") 
                ? File.ReadAllLines("dictionary_english.txt") 
                : new string[] { "apple", "believe", "receive", "leisure", "weigh" };

            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] wordsArr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // #region LINQ - Restriction Operators
            // Console.WriteLine("========== Restriction Operators ==========");
            
            // var outOfStock = ProductList.Where(p => p.UnitsInStock == 0);
            // Console.WriteLine($"Out of Stock Products Count: {outOfStock.Count()}");
            
            // var inStockExpensive = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            // Console.WriteLine($"In Stock & Price > 3.00 Count: {inStockExpensive.Count()}");
            
            // var shortNamedDigits = digits.Where((d, i) => d.Length < i);
            // Console.WriteLine("Digits shorter than value:");
            // foreach (var d in shortNamedDigits) Console.WriteLine(d);
            
            // #endregion

            // #region LINQ - Element Operators
            // Console.WriteLine("\n========== Element Operators ==========");
            
            // var firstOutOfStock = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            // Console.WriteLine($"First Out of Stock: {firstOutOfStock?.ProductName ?? "None"}");
            
            // var expensiveProduct = ProductList.FirstOrDefault(p => p.UnitPrice > 1000M);
            // Console.WriteLine($"Product > 1000: {expensiveProduct?.ProductName ?? "None"}");
            
            // var secondNumberGreaterThan5 = numbers.Where(n => n > 5).ElementAt(1);
            // Console.WriteLine($"Second number > 5: {secondNumberGreaterThan5}");
            
            // #endregion

            // #region LINQ - Aggregate Operators
            // Console.WriteLine("\n========== Aggregate Operators ==========");
            
            // var oddCount = numbers.Count(n => n % 2 != 0);
            // Console.WriteLine($"Odd numbers count: {oddCount}");

            // var customerOrdersCount = CustomerList.Select(c => new { c.Name, OrderCount = c.Orders.Length });
            // Console.WriteLine($"Customers processed: {customerOrdersCount.Count()}");

            // var categoryProductsCount = ProductList.GroupBy(p => p.Category)
            //                                        .Select(g => new { Category = g.Key, Count = g.Count() });
            // Console.WriteLine($"Categories processed: {categoryProductsCount.Count()}");

            // var totalNumbers = numbers.Sum();
            // Console.WriteLine($"Sum of numbers: {totalNumbers}");

            // var totalDictChars = dictionaryWords.Sum(w => w.Length);
            // Console.WriteLine($"Total dictionary characters: {totalDictChars}");
            
            // #endregion

            // #region LINQ - Ordering Operators
            // Console.WriteLine("\n========== Ordering Operators ==========");
            
            // var sortedByName = ProductList.OrderBy(p => p.ProductName);
            // var caseInsensitiveSort = wordsArr.OrderBy(w => w, new CaseInsensitiveComparer());
            // var sortedByStockDesc = ProductList.OrderByDescending(p => p.UnitsInStock);
            // var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);
            // var sortedWordsByLengthThenCaseInsensitive = wordsArr.OrderBy(w => w.Length).ThenBy(w => w, new CaseInsensitiveComparer());
            // var sortedByCategoryThenPrice = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            // var sortedWordsByLengthThenDesc = wordsArr.OrderBy(w => w.Length).ThenByDescending(w => w, new CaseInsensitiveComparer());

            // var reversedIDigits = digits.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
            // Console.WriteLine("Reversed digits with 'i' as second letter:");
            // foreach (var d in reversedIDigits) Console.WriteLine(d);
            
            // #endregion

            // #region LINQ - Transformation Operators
            // Console.WriteLine("\n========== Transformation Operators ==========");
            
            // var productNames = ProductList.Select(p => p.ProductName);
            // var upperLowerWords = wordsArr.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            // var productProperties = ProductList.Select(p => new { p.ProductID, p.ProductName, Price = p.UnitPrice });

            // var matchesPosition = numbers.Select((n, i) => new { Number = n, InPlace = (n == i) });
            // foreach (var item in matchesPosition) Console.WriteLine($"{item.Number}: {item.InPlace}");

            // int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            // int[] numbersB = { 1, 3, 5, 7, 8 };
            
            // var pairs = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };
            
            // Console.WriteLine("\nPairs where a < b:");
            // foreach (var p in pairs) Console.WriteLine($"{p.A} is less than {p.B}");

            // var smallOrders = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500.00);
            // var recentOrders = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
            
            // #endregion

            // #region LINQ - Partitioning Operators
            // Console.WriteLine("\n========== Partitioning Operators ==========");
            
            // var first3WaOrders = CustomerList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Take(3);
            // var skip2WaOrders = CustomerList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Skip(2);
            // var takeWhileNumbers = numbers.TakeWhile((n, i) => n >= i);
            // var skipWhileNotDivisibleBy3 = numbers.SkipWhile(n => n % 3 != 0);
            // var skipWhileGreaterOrEqualToPosition = numbers.SkipWhile((n, i) => n >= i);

            // Console.WriteLine($"takeWhileNumbers count: {takeWhileNumbers.Count()}");
            // Console.WriteLine($"skipWhileNotDivisibleBy3 count: {skipWhileNotDivisibleBy3.Count()}");
            
            // #endregion

            // #region LINQ - Quantifiers Operators
            // Console.WriteLine("\n========== Quantifiers Operators ==========");
            
            // bool containsEI = dictionaryWords.Any(w => w.Contains("ei"));
            // Console.WriteLine($"Any word contains 'ei': {containsEI}");

            // var categoriesWithOutOfStock = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0));
            // Console.WriteLine($"Categories with out of stock products: {categoriesWithOutOfStock.Count()}");

            // var categoriesAllInStock = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0));
            // Console.WriteLine($"Categories with all products in stock: {categoriesAllInStock.Count()}");
            
            // #endregion
        }
    }
}