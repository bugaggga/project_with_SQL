USE Training_base_Bogachev

GO
CREATE VIEW Sum_Orders
AS SELECT
	t1.ONUM,
	SUM(t3.PRICE * t2.QUANTITY) AS '—”ÃÃ¿ «¿ ¿«¿',
	ODATE
	FROM Orders t1
	INNER JOIN Order_Details t2 ON t1.ONUM = t2.ONUM
	INNER JOIN Product t3 ON t2.PNUM = t3.PNUM
	GROUP BY t1.ONUM, t1.ODATE


