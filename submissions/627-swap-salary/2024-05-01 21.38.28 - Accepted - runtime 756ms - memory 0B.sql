/* Write your T-SQL query statement below */
Update Salary
set sex = case when sex = 'f' then 'm'
            else 'f'
            end