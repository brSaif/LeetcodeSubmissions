/* Write your T-SQL query statement below */
SELECT salary as 'SecondHighestSalary'
FROM Employee
Order BY salary desc
OFFSET 1 ROWS 
FETCH NEXT 1 ROWS ONLY;
