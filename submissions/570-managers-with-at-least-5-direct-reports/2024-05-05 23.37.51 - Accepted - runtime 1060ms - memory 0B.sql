/* Write your T-SQL query statement below */
Select name from employee where id in (select managerId from employee group by managerId having count(*) >= 5)