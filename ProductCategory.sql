SELECT p.Name, o.Name FROM Products as p
LEFT JOIN ProductCategory as pc on p.ID = pc.CategoryID
LEFT JOIN Category as c on c.ID = pc.CategoryID