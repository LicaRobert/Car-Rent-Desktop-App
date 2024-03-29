ALTER TABLE Reservations DROP CONSTRAINT Reservations_Cars;

ALTER TABLE Reservations DROP CONSTRAINT Reservations_Coupons;

ALTER TABLE Reservations DROP CONSTRAINT Reservations_Customers;

ALTER TABLE Reservations DROP CONSTRAINT Reservations_ReservationStatuses;

ALTER TABLE RolesPermissions DROP CONSTRAINT RolesPermissions_Permissions;

ALTER TABLE RolesPermissions DROP CONSTRAINT ScreenPermissions_Roles;

ALTER TABLE Users DROP CONSTRAINT Users_Roles;

-- tables
DROP TABLE Cars;

DROP TABLE Coupons;

DROP TABLE Customers;

DROP TABLE CarRent;

DROP TABLE Permissions;

DROP TABLE ReservationStatuses;

DROP TABLE Reservations;

DROP TABLE Roles;

DROP TABLE RolesPermissions;

DROP TABLE Users;