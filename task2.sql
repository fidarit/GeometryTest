select 
	prod.name as [�������], 
	cat.name as [���������]
from products prod
	left join categories cat on cat.id = prod.idcategory