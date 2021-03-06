
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO

Public Module Extensions_783

	''' <summary>
	'''     Gets the root directory information of the specified @this.
	''' </summary>
	''' <param name="this">The @this from which to obtain root directory information.</param>
	''' <returns>
	'''     The root directory of <paramref name="this" />, such as "C:\", or null if <paramref name="this" /> is null,
	'''     or an empty string if
	'''     <paramref
	'''         name="this" />
	'''     does not contain root directory information.
	''' </returns>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this" /> contains one or more of the invalid
	'''     characters defined in
	'''     <see
	'''         cref="M:System.IO.Path.GetInvalidPathChars" />
	'''     .-or- <see cref="F:System.String.Empty" /> was passed to
	'''     <paramref
	'''         name="this" />
	'''     .
	''' </exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetPathRoot(this As FileInfo) As [String]
		Return Path.GetPathRoot(this.FullName)
	End Function
End Module


