select 
	prod.name as [Продукт], 
	cat.name as [Категория]
from products prod
	left join categories cat on cat.id = prod.idcategory