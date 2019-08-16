#Performance timing using Fody compile time weaver. 

In this repository, I use the compile time weaver fody nuget package to wrap performance diagnostics code around a method to calculate the time taken by the method execution. 

#About Fody Compile Time Weaver:

From the author: 
This tool rewrites assembly at VisualStudio.Net build time, so that your code get these achievements that dynamic proxy based enhancement cannot give:
Much better performance, no dynamic proxy, no thread block or reflection at run time.
Directly instantiate your weaved classes with new operator
weave virtual methods/properties
weave static methods/properties
weave  extension methods
weave constructors
Read more at https://brooksidebeauty.blogspot.com/2019/02/compiletimeweaverfody-v317.html

The nuget package: https://www.nuget.org/packages/CompileTimeWeaver.Fody

Works on .Net Platforms:
Framework 4.6.1
NetStandard 2.0


