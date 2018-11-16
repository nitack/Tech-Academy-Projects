create database db_library
go

use db_library

	create table library_branch (
		branchid int primary key not null identity (1,1),
		branchname varchar(50) not null,
		address varchar(50) not null
	);

	create table publisher (
		publishername varchar(50) primary key not null,
		address varchar(50) not null,
		phone varchar(50) not null
	);

	create table books (
		bookid int primary key not null identity (1001,1),
		title varchar(50) not null,
		publishername varchar(50) not null constraint fk_publishername foreign key references publisher(publishername) on update cascade on delete cascade
	);

	create table book_copies (
		bookid int not null constraint fk_bookid foreign key references books(bookid) on update cascade on delete cascade,
		branchid int not null constraint fk_branchid foreign key references library_branch(branchid) on update cascade on delete cascade,
		number_of_copies int not null
	);

	create table book_authors (
		bookid int not null constraint fk_books foreign key references books(bookid) on update cascade on delete cascade,
		authorname varchar(50) not null
	);

	create table borrower (
		cardno int primary key not null identity (2001,1),
		name varchar(50) not null,
		address varchar(50) not null,
		phone varchar(50) not null
	);

	create table book_loans (
		bookid int not null foreign key references books(bookid) on update cascade on delete cascade,
		branchid int not null foreign key references library_branch(branchid) on update cascade on delete cascade,
		cardno int not null constraint fk_cardno foreign key references borrower(cardno) on update cascade on delete cascade,
		dateout date not null,
		datedue date not null
	);

	insert into library_branch
		(branchname, address)
		values
		('Sharpstown', '123 Sharpstown Way'),
		('Central', '123 Main Street'),
		('West Valley', '123 West Valley Hwy'),
		('East Valley', '123 East Valley Hwy')
	;

	insert into publisher
		(publishername, address, phone)
		values
		('Picador', '123 someplace', '888-888-8888'),
		('Doubleday', '123 someplace', '888-888-8888'),
		('Tor Books', '123 someplace', '888-888-8888'),
		('Crown', '123 someplace', '888-888-8888'),
		('Worldbuilders Press', '123 someplace', '888-888-8888'),
		('47North', '123 someplace', '888-888-8888'),
		('Del Rey', '123 someplace', '888-888-8888'),
		('Aleron Kong', '123 someplace', '888-888-8888'),
		('William D Arand', '123 someplace', '888-888-8888'),
		('William Morrow', '123 someplace', '888-888-8888'),
		('Broadway Books', '123 someplace', '888-888-8888'),
		('Spectra', '123 someplace', '888-888-8888')
	;

	insert into books
		(title, publishername)
		values
		('The Lost Tribe', 'Picador'),
		('Carrie', 'Doubleday'),
		('The Stand', 'Doubleday'),
		('Elantris', 'Tor Books'),
		('The Way of Kings', 'Tor Books'),
		('The Martian', 'Crown'),
		('Artemis', 'Crown'),
		('We Are Legion (We Are Bob)', 'Worldbuilders Press'),
		('For We are Many', 'Worldbuilders Press'),
		('All These Worlds', 'Worldbuilders Press'),
		('Off to Be the Wizard', '47North'),
		('Red Rising', 'Del Rey'),
		('The Land: Founding', 'Aleron Kong'),
		('The Land: Forging', 'Aleron Kong'),
		('Super Sales on Super Heroes', 'William D Arand'),
		('Seveneves', 'William Morrow'),
		('Ready Player One', 'Broadway Books'),
		('American Gods', 'William Morrow'),
		('Stardust', 'William Morrow'),
		('Hyperion', 'Spectra')
		;

	insert into book_copies
		(bookid, branchid, number_of_copies)
		values
		('1001', '1', '2'),
		('1004', '1', '2'),
		('1005', '1', '2'),
		('1006', '1', '2'),
		('1007', '1', '2'),
		('1008', '1', '2'),
		('1009', '1', '2'),
		('1010', '1', '2'),
		('1011', '1', '2'),
		('1012', '1', '2'),
		('1002', '2', '2'),
		('1003', '2', '2'),
		('1013', '2', '2'),
		('1014', '2', '2'),
		('1015', '2', '2'),
		('1016', '2', '2'),
		('1017', '2', '2'),
		('1018', '2', '2'),
		('1019', '2', '2'),
		('1020', '2', '2'),
		('1001', '3', '2'),
		('1002', '3', '2'),
		('1003', '3', '2'),
		('1004', '3', '2'),
		('1005', '3', '2'),
		('1006', '3', '2'),
		('1007', '3', '2'),
		('1008', '3', '2'),
		('1009', '3', '2'),
		('1010', '3', '2'),
		('1011', '4', '2'),
		('1012', '4', '2'),
		('1013', '4', '2'),
		('1014', '4', '2'),
		('1015', '4', '2'),
		('1016', '4', '2'),
		('1017', '4', '2'),
		('1018', '4', '2'),
		('1019', '4', '2'),
		('1020', '4', '2')
	;

	insert into book_authors
		(bookid, authorname)
		values
		(1001, 'Mark Lee'),
		(1002, 'Stephen King'),
		(1003, 'Stephen King'),
		(1004, 'Brandon Sanderson'),
		(1005, 'Brandon Sanderson'),
		(1006, 'Andy Weir'),
		(1007, 'Andy Weir'),
		(1008, 'Dennis Taylor'),
		(1009, 'Dennis Taylor'),
		(1010, 'Dennis Taylor'),
		(1011, 'Scott Meyer'),
		(1012, 'Pierce Brown'),
		(1013, 'Aleron Kong'),
		(1014, 'Aleron Kong'),
		(1015, 'William D Arand'),
		(1016, 'Neil Stephenson'),
		(1017, 'Ernest Cline'),
		(1018, 'Neil Gaiman'),
		(1019, 'Neil Gaiman'),
		(1020, 'Dan Simmons')
	;

	insert into borrower
		(name, address, phone)
		values
		('John Doe', '123 someplace', '888-888-8888'),
		('Jane Doe', '123 someplace', '888-888-8888'),
		('Bill Gates', '123 someplace', '888-888-8888'),
		('Steve Jobs', '123 someplace', '888-888-8888'),
		('Jeff Bazos', '123 someplace', '888-888-8888'),
		('Paul Allen', '123 someplace', '888-888-8888'),
		('Ellon Musk', '123 someplace', '888-888-8888'),
		('Steve Balmer', '123 someplace', '888-888-8888')
	;

	insert into book_loans
		(bookid, branchid, cardno, dateout, datedue)
		values
		( 1001, 1, 2001, '2018-11-01', '2018-12-01'),
		( 1004, 1, 2001, '2018-11-01', '2018-12-01'),
		( 1005, 1, 2001, '2018-11-01', '2018-12-01'),
		( 1006, 1, 2001, '2018-11-01', '2018-12-01'),
		( 1007, 1, 2001, '2018-11-01', '2018-12-01'),
		( 1002, 2, 2002, '2018-11-01', '2018-12-01'),
		( 1003, 2, 2002, '2018-11-01', '2018-12-01'),
		( 1014, 2, 2002, '2018-11-01', '2018-12-01'),
		( 1015, 2, 2002, '2018-11-01', '2018-12-01'),
		( 1016, 2, 2002, '2018-11-01', '2018-12-01'),
		( 1001, 3, 2003, '2018-01-01', '2018-02-01'),
		( 1002, 3, 2004, '2018-01-01', '2018-02-01'),
		( 1003, 3, 2005, '2018-01-01', '2018-02-01'),
		( 1004, 3, 2006, '2018-01-01', '2018-02-01'),
		( 1005, 3, 2007, '2018-01-01', '2018-02-01'),
		( 1006, 3, 2008, '2018-01-01', '2018-02-01'),
		( 1007, 3, 2004, '2018-01-01', '2018-02-01'),
		( 1008, 3, 2005, '2018-01-01', '2018-02-01'),
		( 1009, 3, 2006, '2018-01-01', '2018-02-01'),
		( 1010, 3, 2007, '2018-01-01', '2018-02-01'),
		( 1011, 4, 2008, '2018-01-01', '2018-02-01'),
		( 1012, 4, 2001, '2018-01-01', '2018-02-01'),
		( 1013, 4, 2002, '2018-01-01', '2018-02-01'),
		( 1014, 4, 2003, '2018-01-01', '2018-02-01'),
		( 1015, 4, 2004, '2018-01-01', '2018-02-01'),
		( 1016, 4, 2005, '2018-01-01', '2018-02-01'),
		( 1017, 4, 2006, '2018-01-01', '2018-02-01'),
		( 1018, 4, 2007, '2018-01-01', '2018-02-01'),
		( 1019, 4, 2008, '2018-01-01', '2018-02-01'),
		( 1020, 4, 2001, '2018-01-01', '2018-02-01'),
		( 1001, 3, 2002, '2018-01-01', '2018-02-01'),
		( 1002, 3, 2003, '2018-01-01', '2018-02-01'),
		( 1003, 3, 2004, '2018-01-01', '2018-02-01'),
		( 1004, 3, 2005, '2018-01-01', '2018-02-01'),
		( 1005, 3, 2006, '2018-01-01', '2018-02-01'),
		( 1006, 3, 2007, '2018-01-01', '2018-02-01'),
		( 1007, 3, 2008, '2018-01-01', '2018-02-01'),
		( 1008, 3, 2001, '2018-01-01', '2018-02-01'),
		( 1009, 3, 2002, '2018-01-01', '2018-02-01'),
		( 1010, 3, 2003, '2018-01-01', '2018-02-01'),
		( 1011, 4, 2004, '2018-01-01', '2018-02-01'),
		( 1012, 4, 2005, '2018-01-01', '2018-02-01'),
		( 1013, 4, 2006, '2018-01-01', '2018-02-01'),
		( 1014, 4, 2007, '2018-01-01', '2018-02-01'),
		( 1015, 4, 2007, '2018-01-01', '2018-02-01'),
		( 1016, 4, 2001, '2018-01-01', '2018-02-01'),
		( 1017, 4, 2002, '2018-01-01', '2018-02-01'),
		( 1018, 4, 2003, '2018-01-01', '2018-02-01'),
		( 1019, 4, 2004, '2018-01-01', '2018-02-01'),
		( 1020, 4, 2005, '2018-01-01', '2018-02-01')
	;



