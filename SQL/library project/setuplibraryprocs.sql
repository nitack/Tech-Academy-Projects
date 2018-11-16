use db_library

/* procedure 1.) How many copies of the book titled "The Lost Tribe" are owned by the library branch whose name is "Sharpstown"? */

create procedure dbo.ltsharpstown
as
select
	a1.branchname, (a2.number_of_copies)
	from library_branch a1
	inner join book_copies a2
	on a1.branchid = a2.branchid
	inner join books a3
	on a2.bookid = a3.bookid
	where title = 'The Lost Tribe' and branchname = 'Sharpstown'

/* procedure 2.) How many copies of the book titled "The Lost Tribe" are owned by each library branch? */

create procedure dbo.ltcopies
as	
select
	a1.branchname, (a2.number_of_copies)
	from library_branch a1
	inner join book_copies a2
	on a1.branchid = a2.branchid
	inner join books a3
	on a2.bookid = a3.bookid
	where title = 'The Lost Tribe'

/*  3.) Retrieve the names of all borrowers who do not have any books checked out. */

create procedure dbo.nothingborrowed
as	

select
	a1.name
	from borrower a1
	left join book_loans a2
	on a2.cardno = a1.cardno
	where a2.cardno is null


/*  Procedure 4.) For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today, retrieve the book title, the borrower's name, and the borrower's address. */

create procedure dbo.duetoday
as	

select
	a3.title, a4.name, a4.address
	from library_branch a1
	inner join book_loans a2
	on a1.branchid = a2.branchid
	inner join books a3
	on a2.bookid = a3.bookid
	inner join borrower a4
	on a2.cardno = a4.cardno
	where a1.branchname = 'Sharpstown' and a2.datedue = convert (date, getdate())


/* procedure 5.) For each library branch, retrieve the branch name and the total number of books loaned out from that branch. */


create procedure dbo.totalout
as	

select
	a1.branchname, count (*)
	from library_branch a1
	inner join book_loans a2
	on a1.branchid = a2.branchid
	group by a1.branchname

/* procedure 6.) Retrieve the names, addresses, and the number of books checked out for all borrowers who have more than five books checked out. */

create procedure dbo.morethanfive
as	

select
	name, address, count(a2.cardno) as 'Number of Books'
	from borrower a1
	inner join book_loans a2
	on a1.cardno = a2.cardno
	where a2.cardno>5 
	group by name, address

/* procedure 7.) For each book authored (or co-authored) by "Stephen King", retrieve the title and the number of copies owned by the library branch whose name is "Central". */

create procedure dbo.stephenking
as	

select
	a4.title, sum(a1.number_of_copies) as 'Copies'
	from book_copies a1
	inner join book_authors a2
	on a1.bookid = a2.bookid
	inner join library_branch a3
	on a1.branchid = a3.branchid
	inner join books a4
	on a1.bookid = a4.bookid
	where a3.branchname = 'Central' and a2.authorname = 'Stephen King'
	group by a4.title