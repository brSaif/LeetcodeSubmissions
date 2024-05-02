With HighSalary (Department, Employee, Salary, rn)
AS
(
select d.[name] as DepartmentName, e.[name] as Employee,  e.salary, rank() over (partition by d.[name] order by salary desc) as rn
from Department d
inner join Employee e on e.departmentId = d.id
)

select Department, Employee, Salary
from HighSalary 
where rn = 1