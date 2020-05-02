# Thread safe performance tracking using Fody compile time weaver. 

In this repository, new classes are created to enable thread safe performance tracking of methods using attributes. Each tracking information is then logged into a Singleton instance.This instance can be leater read and the data saved in a more persistent storage if required

The compile time weaver fody nuget package is used to wrap performance diagnostics code around a method to calculate the time taken by the method execution. 

### Targets .Net Platforms:
Framework 4.6.1

### About Fody Compile Time Weaver:

Read at https://brooksidebeauty.blogspot.com/2019/02/compiletimeweaverfody-v317.html

The nuget package: https://www.nuget.org/packages/CompileTimeWeaver.Fody



