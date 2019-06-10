# SimplePrefix
[![Build Status](https://travis-ci.org/pichlermarc/SimplePrefix.svg?branch=master)](https://travis-ci.org/pichlermarc/SimplePrefix) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=pichlermarc_SimplePrefix&metric=alert_status)](https://sonarcloud.io/dashboard?id=pichlermarc_SimplePrefix)

***A .NET Core 2.1 Library for converting numbers from and to SI or IEC prefixed representation.***

## Getting Started

### NuGet Package
Add "SimplePrefix" as a dependency to your project. The library is available as a [NuGet-Package](https://www.nuget.org/packages/SimplePrefix/).

### Example Usage

SimplePrefix is intended to be used with large numbers that you might want to make readable. 


#### Converting numbers
For instance, converting to a prefixed representation:

```c#
// I want to convert bytes to Kibibytes
var bytesRead = 2048;

// Conversion:
var kibibytes = Prefixes.ConvertTo(Prefixes.IEC.Kibi, bytesRead); // returns 2, as in 2 Kibibytes

// Alternatives:
kibibytes = Prefixes.ConvertTo(Prefixes.IEC["kibi"], bytesRead);  // returns 2, as in 2 Kibibytes
kibibytes = Prefixes.IEC.Kibi.ConvertTo(bytesRead);               // returns 2, as in 2 Kibibytes
kibibytes = Prefixes.IEC["kibi"].ConvertTo(bytesRead);            // returns 2, as in 2 Kibibytes
```

Similarly, the same works for converting from a prefixed representation:

```c#
// I want to convert to Bytes
var kibiytesRead = 2;

// Conversion:
var bytesRead = Prefixes.ConvertFrom(Prefixes.IEC.Kibi, bytesRead);    // returns 2048, as in 2048 Bytes

// Alternatives:
bytesRead = Prefixes.ConvertFrom(Prefixes.IEC["kibi"], kibibytesRead); // returns 2048, as in 2048 Bytes
bytesRead = Prefixes.IEC.Kibi.ConvertFrom(kibibytesRead);              // returns 2048, as in 2048 Bytes
bytesRead = Prefixes.IEC["kibi"].ConvertFrom(bytesRead);               // returns 2048, as in 2048 Bytes
```

#### Implicit uses of `Prefix` as `decimal`

If necessary, you can use a `Prefix` instance like a `decimal` and do calculations with it. For example:

```
// I want to convert bytes to Kibibytes
decimal bytesRead = 2048m;

// Conversion:
decimal kibibytesRead = bytesRead / Prefixes.IEC.Kibi; // returns 2, as in 2 Kibibytes.
```


#### Available prefixes

Currently two prefix collections are available, `Prefixes.IEC` for binary prefixes, and `Prefixes.SI` for decimal prefixes.

Since both Prefixes.IEC and Prefixes.SI are of type `PrefixCollection` you can use ```Prefixes.IEC.PrefixNames``` or ```Prefixes.SI.PrefixNames``` to get the available names that can be used with their index accessor.

## Adding your own prefixes

To add your own prefixes, you can create new instances of the `PrefixTypes.Prefix` class. You can also extend the `Prefix` class, if you want to customize `ConvertTo()` and `ConvertFrom()` behavior.

To get similar access to Prefix classes, you can extend the `PrefixContainers.PrefixContainer` class, and add fields to this class. If you add the `PrefixField` attribute, `PrefixContainer` will add them to the available prefix names, and provide you with access to their names during runtime, as well as the ability to use the index accessor on your own `PrefixContainer` to access these items dynamically.

