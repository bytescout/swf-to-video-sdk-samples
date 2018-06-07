'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode

Imports System.Diagnostics
Imports BytescoutSWFToVideo

Class Program
	Friend Shared Sub Main(args As String())
		' Create an instance of SWFToVideo ActiveX object
		Dim converter As New SWFToVideo()

		' Set debug log
		'converter.SetLogFile("log.txt");

		' Register SWFToVideo
		converter.RegistrationName = "demo"
		converter.RegistrationKey = "demo"

		' Set the converter to the live data conversion mode
		' (it will fully load the embedded video stream before the conversion)
		converter.SWFConversionMode = SWFConversionModeType.SWFWithLiveData

		' Enable trasparency - set BEFORE setting input SWF filename
		converter.RGBAMode = True

       	' Set input SWF file
       	converter.InputSWFFileName = "http://bytescout.com/demo/swfscout_VideoSample.swf"
	
		' Select 20th frame
		converter.StartFrame = 20
		converter.StopFrame = 20
		' Save it to file
		converter.ConvertToPNG("frame20.png")

		' Select 50th frame
		converter.StartFrame = 50
		converter.StopFrame = 50
		' Save it to file
		converter.ConvertToPNG("frame50.png")

		' release resources
		System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
		converter = Nothing


		' Open the result in default media player
		Process.Start("frame20.png")
	End Sub
End Class
