/* 
 Please write a DELETE statement and DO NOT write a SELECT statement.
 Write your T-SQL query statement below
 */
delete from Person Where id not in(
                select min(id) from Person 
                Group by email
                )