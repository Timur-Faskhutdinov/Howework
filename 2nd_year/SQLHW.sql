--c3
	--#1
	Select onum as 'onum c3', odate from Orders

	--#5
	Select city, sname, snum, comm from Salespeople

	--#10
	Select distinct cnum from Customers
--c4
	--#1
	Select amt as 'amt c4/c5' from Orders where amt>1000
	
	--#5
	Select * from Customers where rating<=100 and city != 'Rome'  

	--#7
	Select * from Salespeople where (comm>=0.13 and city!='London') or (city='London' and comm<=0.11)
--c5
	--#2
	Select * from Orders where odate in ('03/10/2015','06/10/2015')
	--							(odate= ('03/10/2015') or (odate= ('06/10/2015')))

	--#4
	Select cnum,cname,Customers.city,rating,Customers.snum,sname 
	from Customers Inner Join Salespeople On Customers.snum=Salespeople.snum 
	where sname in('Peel','Motika')
	--	sname='Peel' or sname='Motika'

	--#7
	select * from Customers where cname Like'C%'
--c6
	--#1
	Select SUM(amt) as 'summ c6' from Orders where odate='03/10/2015'

	--#5
	Select Customers.cnum,cname,city,rating,Customers.snum, Min(amt) as 'Min summ'
	from Customers Inner Join Orders on Customers.cnum=Orders.cnum
	group by Customers.cnum,cname,city,rating,Customers.snum

	--#10
	Select odate,min(amt) as 'min summ' from Orders
	group by odate
--c7
	--#1
	select onum,snum, amt*0.12 as 'profit c7' from Orders
	
	--#5
	select rating, cname, cnum from Customers order by rating Desc 

	--#8
	select Customers.cnum, Customers.cname, Sum(amt) as 'summ of orders'
	from Customers Inner Join Orders on Customers.cnum=Orders.cnum
	group by Customers.cnum, Customers.cname
	order by [summ of orders] Desc

--c8
	--#1
	select  onum as 'onum c8',cname
	from Customers Inner Join Orders on Customers.cnum=Orders.cnum

	--#5
	select cname,sname,comm
	from Customers Inner Join Salespeople on Customers.snum=Salespeople.snum
	where comm>0.12

	--#8
	select onum, amt*(comm+1.00) as 'cost of order'
	from Orders Inner Join Salespeople on Orders.snum=Salespeople.snum
	where Salespeople.city='London'

--c9
	--#1
	select first.sname, second.sname, first.city as 'city c9/10'
	from Salespeople first, Salespeople second 
	where (first.city = second.city) and (first.sname<second.sname)
	--#4
	select distinct cust1.cname, cust2.cname 
	from Orders first, Orders second , Customers cust1, Customers cust2 
	where (first.odate=second.odate) and (first.cnum=cust1.cnum) and (second.cnum=cust2.cnum) and(cust1.cname<cust2.cname)
	--#6
	select first.sname, first.city 
	from Salespeople first, Salespeople second 
	where second.snum=1001 and first.comm>second.comm
--c10
	--#1
	Select * from Orders
	where Orders.cnum=(select distinct Customers.cnum from Customers where cname='Cisneros')
	--#3
	Select cname, rating
	from Customers INNER JOIN Orders on Customers.cnum=Orders.cnum
	group by cname, rating
	having max(amt)>(Select AVG(amt) from Orders)
	--#6
	Select Customers.cname, COUNT(amt) as 'Orders count'
	from Customers INNER JOIN Orders on Customers.cnum=Orders.cnum
	group by Customers.cname
	having min(amt)>(Select AVG(amt) from Orders)
--c11/12
	--#1
	Select first.cnum as 'cnum c11/12', first.cname
	from Customers first
	where first.rating in 
	(Select MAX(second.rating) from Customers second where first.city=second.city)
	
	--#3
	select * from Customers first
	where not exists ( select * from Orders second where second.snum<>first.snum)
	
	--#6
	select distinct * from Customers first
	where exists(Select * from Orders second where (second.cnum<>first.cnum and first.snum=second.snum))