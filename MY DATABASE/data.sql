 use academy_net

INSERT INTO Roles (Name, Description) VALUES ('Administrator','Role with full access to all features in the system.')
INSERT INTO Roles (Name, Description) VALUES ('Manager','Role with full access to all features in the system, except manage users and permissions')
INSERT INTO Roles (Name, Description) VALUES ('Salesperson','Role with limited access to the system. Cannot manage cars,coupons cancel a reservation or manage users and permissions')

INSERT INTO Users ( Password, Enabled, RoleID) VALUES ('pass123',1,1)
INSERT INTO Users ( Password, Enabled, RoleID) VALUES ('123pass',1,2)
INSERT INTO Users ( Password, Enabled, RoleID) VALUES ('qwert',1,3)


INSERT INTO [Permissions] ( Name,Description ) VALUES ('CUST_001','CUSTOMERS REGISTRATION')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('CUST_002','CUSTOMERS LIST')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('CUST_003','CUSTOMERS EDIT')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('CUST_003','CUSTOMERS REMOVAL')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('RESERV_001','RESERVATION REGISTRATION')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('RESERV_002','RESERVATION LIST')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('RESERV_003','RESERVATION EDIT')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('RESERV_004','RESERVATION CHANGE STATUS')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('CARS_001','CARS REGISTRATION')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('CARS_002','CARS LIST')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('CARS_003','CARS EDIT')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('CARS_004','CARS REMOVAL')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('CARS_001','CARS REGISTRATION')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('COUPON_001','COUPON REGISTRATION')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('COUPON_001','COUPON EDIT')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('COUPON_001','COUPON LIST')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('COUPON_001','COUPON REMOVAL')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('USER_001','USERS REGISTRATION')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('USER_002','USERS LIST')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('USER_003','USERS EDIT')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('USER_003','USERS REMOVAL')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('PERMS_001','PERMISSION REGISTRATION')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('PERMS_002','PERMISSION LIST')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('PERMS_003','PERMISSION EDIT')
INSERT INTO [Permissions] ( Name,Description ) VALUES ('PERMS_003','PERMISSION REMOVAL')

INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,1)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,2)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,3)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,4)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,5)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,6)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,7)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,8)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,9)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,10)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,11)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,12)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,13)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,14)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,15)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,16)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,17)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,18)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,19)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,20)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,21)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,22)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,23)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,24)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (1,25)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,1)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,2)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,3)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,4)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,5)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,6)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,7)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,8)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,9)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,10)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,11)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,12)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,13)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,14)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,15)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,16)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (2,17)

INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (3,5)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (3,6)
INSERT INTO RolesPermissions (RoleID, PermissionID) VALUES (3,7)


INSERT INTO ReservationStatuses (NAME,Description) VALUES ('OPEN','RESERVATION IS OPEN')
INSERT INTO ReservationStatuses (NAME,Description) VALUES ('CLOSED','RESERVATION WAS FINALIZED WITH SUCCESS')
INSERT INTO ReservationStatuses (NAME,Description) VALUES ('CANCELED','A PROBLEM HAPPENED AND THE RESERVATION NEEDED TO BE CANCELED')

insert into Coupons (CouponCode, Description, Discount) values ('3B3O18D', 'Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', 85.95);
insert into Coupons (CouponCode, Description, Discount) values ('8D2K06S', 'Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.', 41.57);
insert into Coupons (CouponCode, Description, Discount) values ('2Q6X40C', 'Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.', 1.49);
insert into Coupons (CouponCode, Description, Discount) values ('2F8B39K', 'Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.', 74.33);
insert into Coupons (CouponCode, Description, Discount) values ('2Z7H30G', 'Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', 88.17);
insert into Coupons (CouponCode, Description, Discount) values ('5G0G50D', 'Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.', 19.21);
insert into Coupons (CouponCode, Description, Discount) values ('8B0D02W', 'In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.', 10.46);
insert into Coupons (CouponCode, Description, Discount) values ('3H8V03E', 'Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.', 53.41);
insert into Coupons (CouponCode, Description, Discount) values ('1D2P44D', 'Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.', 34.83);
insert into Coupons (CouponCode, Description, Discount) values ('0I0J93K', 'Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.', 22.74);
insert into Coupons (CouponCode, Description, Discount) values ('6F5V84O', 'Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.', 18.62);
insert into Coupons (CouponCode, Description, Discount) values ('7M1T92U', 'Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.', 16.65);
insert into Coupons (CouponCode, Description, Discount) values ('9L4P02Z', 'Fusce consequat. Nulla nisl. Nunc nisl.', 61.36);
insert into Coupons (CouponCode, Description, Discount) values ('5M8Y28F', 'Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.', 14.99);
insert into Coupons (CouponCode, Description, Discount) values ('9S4B91E', 'Fusce consequat. Nulla nisl. Nunc nisl.', 17.44);
insert into Coupons (CouponCode, Description, Discount) values ('4X5B86G', 'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.', 76.79);
insert into Coupons (CouponCode, Description, Discount) values ('7D8G62H', 'Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.', 66.19);
insert into Coupons (CouponCode, Description, Discount) values ('3Y7H09U', 'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.', 69.37);
insert into Coupons (CouponCode, Description, Discount) values ('3A6K17H', 'Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.', 71.91);
insert into Coupons (CouponCode, Description, Discount) values ('9N9I71O', 'Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem.', 42.52);
insert into Coupons (CouponCode, Description, Discount) values ('8S3J67A', 'Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.', 43.36);
insert into Coupons (CouponCode, Description, Discount) values ('7M8Y56R', 'Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', 29.13);
insert into Coupons (CouponCode, Description, Discount) values ('3X5L91B', 'Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.', 67.67);
insert into Coupons (CouponCode, Description, Discount) values ('3N5Z48X', 'In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.', 48.94);
insert into Coupons (CouponCode, Description, Discount) values ('2K7F29X', 'Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.', 42.03);
insert into Coupons (CouponCode, Description, Discount) values ('1P9V10X', 'Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus.', 16.63);
insert into Coupons (CouponCode, Description, Discount) values ('7O5O45D', 'Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.', 51.55);
insert into Coupons (CouponCode, Description, Discount) values ('2K7K94Y', 'Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.', 69.04);
insert into Coupons (CouponCode, Description, Discount) values ('5G9F86G', 'Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', 68.52);
insert into Coupons (CouponCode, Description, Discount) values ('5O7I49P', 'Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.', 12.6);
insert into Coupons (CouponCode, Description, Discount) values ('0R2B94U', 'Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', 78.17);
insert into Coupons (CouponCode, Description, Discount) values ('9B9A25V', 'Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.', 2.61);
insert into Coupons (CouponCode, Description, Discount) values ('4U3C86Y', 'Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.', 30.24);
insert into Coupons (CouponCode, Description, Discount) values ('0I3X57G', 'Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.', 8.5);
insert into Coupons (CouponCode, Description, Discount) values ('1R2A49Q', 'Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.', 62.59);
insert into Coupons (CouponCode, Description, Discount) values ('8Q2I73G', 'Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.', 48.68);
insert into Coupons (CouponCode, Description, Discount) values ('1S5K87Z', 'Sed ante. Vivamus tortor. Duis mattis egestas metus.', 23.25);
insert into Coupons (CouponCode, Description, Discount) values ('3Y2R09W', 'Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque.', 60.47);
insert into Coupons (CouponCode, Description, Discount) values ('9Z3Z26L', 'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.', 64.69);
insert into Coupons (CouponCode, Description, Discount) values ('5F9E12V', 'Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.', 65.47);
insert into Coupons (CouponCode, Description, Discount) values ('7S3Y89A', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus.', 67.51);
insert into Coupons (CouponCode, Description, Discount) values ('8H4C05G', 'Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.', 65.19);
insert into Coupons (CouponCode, Description, Discount) values ('0Q9Q95B', 'In congue. Etiam justo. Etiam pretium iaculis justo.', 67.06);
insert into Coupons (CouponCode, Description, Discount) values ('0P0V71T', 'Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.', 23.45);
insert into Coupons (CouponCode, Description, Discount) values ('1C7I77J', 'In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.', 43.31);
insert into Coupons (CouponCode, Description, Discount) values ('1T8Y85U', 'Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.', 78.1);
insert into Coupons (CouponCode, Description, Discount) values ('0Z0A27J', 'Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.', 5.59);
insert into Coupons (CouponCode, Description, Discount) values ('6T2Z73T', 'Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.', 64.86);
insert into Coupons (CouponCode, Description, Discount) values ('6M3M61K', 'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.', 19.64);
insert into Coupons (CouponCode, Description, Discount) values ('1U6I84V', 'Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem.', 52.34);

insert into Customers (Name, BirthDate, Location) values ('Felike Piddletown', '1997-12-24', 'Brasov');
insert into Customers (Name, BirthDate, Location) values ('Malcolm Horribine', '1956-03-19', 'Porto Alegre');
insert into Customers (Name, BirthDate, Location) values ('Barrie Tease', '1952-04-12', 'Florianopolis');
insert into Customers (Name, BirthDate, Location) values ('Bevvy Truggian', '1974-08-18', 'Suceava');
insert into Customers (Name, BirthDate, Location) values ('Antony Grebbin', '1982-05-12', 'Bucharest');
insert into Customers (Name, BirthDate, Location) values ('Ulrica Beere', '1959-07-22', 'İzmir');
insert into Customers (Name, BirthDate, Location) values ('Ernesto Patman', '1976-12-26', 'Cluj-Napoja');
insert into Customers (Name, BirthDate, Location) values ('Stevy Brandacci', '1992-06-29', 'Ivano-Frankivsk');
insert into Customers (Name, BirthDate, Location) values ('Gavin Stinson', '1958-09-03', 'İzmir');
insert into Customers (Name, BirthDate, Location) values ('Braden Rives', '1982-01-19', 'Rio de Janeiro');


insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('BP 59 GCM', 'Econoline E350', 'Ford', 408.04);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('JA 97 ZFS', '929', 'Mazda', 329.58);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('VL 91 GVQ', 'Galant', 'Mitsubishi', 84.91);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('EY 09 VKW', '4Runner', 'Toyota', 195.93);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('UQ 06 RBI', 'CL', 'Acura', 448.4);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('UP 92 HGE', 'Laser', 'Ford', 90.84);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('SB 29 LRL', 'Fiero', 'Pontiac', 447.89);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('QL 92 VYC', 'Express 3500', 'Chevrolet', 280.23);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('TB 64 ODA', 'Esprit', 'Lotus', 311.85);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('MF 10 SLY', 'G-Series 2500', 'Chevrolet', 323.6);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('PG 82 UGB', 'Optima', 'Kia', 371.87);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('BL 98 TAX', 'Bonneville', 'Pontiac', 440.79);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('OU 12 ZDS', 'RX-7', 'Mazda', 452.06);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('HO 61 FRO', 'Expo', 'Mitsubishi', 308.68);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('CV 12 KCP', 'MR2', 'Toyota', 62.75);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('GL 17 LLI', 'Sonata', 'Hyundai', 50.41);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('DA 98 LFG', 'Cayenne', 'Porsche', 65.12);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('SS 41 ZNC', 'Leaf', 'Nissan', 98.9);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('CW 25 VSR', 'Aurora', 'Oldsmobile', 171.95);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('ZS 72 BXO', 'Suburban 2500', 'GMC', 393.63);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('HB 38 DRC', 'MDX', 'Acura', 75.48);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('HD 68 LRU', 'GX', 'Lexus', 122.34);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('TK 18 BXD', '2500 Club Coupe', 'GMC', 284.47);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('NE 27 MWD', 'Thunderbird', 'Ford', 162.61);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('NY 89 MGP', '9-7X', 'Saab', 465.53);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('MN 92 VKG', 'Accord', 'Honda', 143.72);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('RV 95 OAN', 'Montana', 'Pontiac', 393.55);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('NW 24 UEA', 'Titan', 'Nissan', 476.08);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('ZV 70 ITU', 'G6', 'Pontiac', 120.68);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('GL 20 MNW', 'Z4 M', 'BMW', 298.67);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('XN 24 SOA', 'Dakota', 'Dodge', 455.21);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('GT 73 SPT', 'Hombre', 'Isuzu', 438.1);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('RM 24 YLI', 'Altima', 'Nissan', 110.51);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('KB 14 RAR', 'Escape', 'Ford', 194.15);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('XE 71 LWZ', 'A8', 'Audi', 447.04);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('ZA 07 IXI', 'G25', 'Infiniti', 146.68);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('UM 71 CJM', '350Z', 'Nissan', 478.5);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('RF 62 URZ', 'X5', 'BMW', 418.98);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('IP 14 ZJW', 'Windstar', 'Ford', 107.06);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('VQ 94 XHK', 'Voyager', 'Plymouth', 186.61);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('PD 06 MYJ', 'G-Class', 'Mercedes-Benz', 432.17);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('WW 83 EJZ', 'SSR', 'Chevrolet', 296.21);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('OQ 97 WOY', 'S-Class', 'Mercedes-Benz', 199.62);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('TU 23 KBG', 'IS', 'Lexus', 495.39);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('NX 99 EMF', 'Voyager', 'Chrysler', 485.0);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('CG 18 HOE', 'Caprice', 'Chevrolet', 63.45);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('CS 06 ZVM', 'Yukon XL 1500', 'GMC', 307.59);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('HS 76 LFE', 'tC', 'Scion', 360.79);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('FU 51 SRN', 'Ram 1500', 'Dodge', 326.32);
insert into Cars (Plate, Model, Manufacturer, PricePerDay) values ('BR 91 YZE', 'Eclipse', 'Mitsubishi', 414.75);
