##20191007 Monday

#Large Project Structure:

	.sln 					SOLUTION

		Main.exe 		APP WHICH RUNS
			private classes
			public classes
			REFERENCE Library.dll
				use classes from library

		Library.dll
			public classes used in multiple projects

		DLL or EXE is called ASSEMBLY
			Assembly has a version and is also signed by a computer certificate

				Allows computer to 

##Encoding

#File extensions:

			.txt
			.jpg

				Rename  myFile.txt to myFile.jpg what is it? It's still a TEXT FILE

#File Signatures:

			Pattern of 1s and 0s at the start of a file when its laid down on disk (written) which indicates the file type.
			File Signatures are publicly known:

										Drive recovery programs can scan the disk for known signatures in order to attempt to recreate deleted files
	
#	ASCII: 

	USA Built first computers ==> US English is default character set on web.

	7 bits ie numbers 0 through 127

	(int)char will yield number eg (int) 'f'

#	ITF8: 
		0 added on end of ASCII
		01010101

		Web is built using characters exclusively from UTF8 set 

		https://getbootstrap.com/docs/4.3/getting-started/introduction/#starter-template
		getbootstrap.com ==> <meta charset="utf-8">

		BASE64 is therefore used to TRANSPORT all data which is not in this simple character set:

			<<<complex data>>> ==> chop it into blocks of 6bit wide
							   ==> each 6bit block allocated ASCII letter
							   ==> SEND DATA AS ASCII
							   ==> Process reversed at receiving end

#	UTF16: 
	Russian/Chinese languages etc have many characters
	using 16 bits we can now describe most characters in world:

			ASCII 2^7=128
			UTF16 => 2^16 ==> 65536 characters

#	UNICODE = UTF16

# 	C# .NET default encoding is 16bit ((but .NET core defaulting ??? 8 bit ???))

# 	SecureString can be used as an input type which is slightly more secure than standard string.
	No strings are completely secure.

============================================================================================================

##STREAMING AND SERIALIZATION

	Streaming = getting data across the internet

		Stream to ...

			#FILE SYSTEM (local computer)

				.NET RUNTIME ==> think of hard drive as remote system ==> streaming to/from hard drive

			#Memory of the local computer ie: RAM

				Memory is different because we can ALLOCATE A FIXED UMBER OF BYTES FOR THE DATA
					Allocate the START BYTE and FINISH BYTE of the data exactly
					Pointer at set position

			#Network

				http:// 		web
				https://	 	secure web
				ftp:// 			files
				smb:// 			shares
				//servershare 	shares

	ASYNC 		not wait, will continue so the user feels like the app is still 'responsive'.
				Data will return and another method runs called the 'callback'. 
				(eg: i ask someone to go to WASABI to get me food: when they comeback with food i will start the Eat() method which is called the callback)

	SYNC 		wait for the operation: 'pause' or 'hang' the entire application

	HOW MUCH IS THE PROGRAMMER INVOLVED:
		Almost none!
			Make call and let OS ==> handle detail. Programmer just handle incoming data

##Serialization

	Converting data into a form for 'streaming' ie a linear sequence of 1's and 0's to be sent across the internet.

	Customer Object
		==>serialize part of it 010001011010001000101101010 
		==>send
		==>Unpack ==> Recreate customer at the other end (deserialization)

	Customer ==> Serialize => stream => deserialize => customer

	Serialize to 3 types of data for sending:

		XML: 	ASCII UTF-8 	primarily for web

		JSON: 	ASCII UTF-8 	primarily for web 			NEWTONSOFT.JSON (3rd party library)

		BINARY: 1001001010101101 ==> no data conversion
									==> Use to send Data do RAM

									primarily for RAM/Memory

									(Files can be any of these three XML/JSON/BINARY other file type)