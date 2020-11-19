# Wavlang Documentation

## Basic Syntax
Every Wavlang macro is enclosed within square brackets, and each parameter is separated by commas, like this: `[<macroName>,<params>]`. Press the "Convert Wavlang to Regular Hex" button to change all Wavlang in the data field to regular hex. This action is irreversible, but it is not necessary to save a file as when the file is saved, WAVFileCreator does this in the background.

## `mul` Macro
The `mul` macro is the most simple macro. It's formatted as `[mul,<hex>,<count>]`, where hex is the hex string to repeat and coutn is the number of times to repeat it. It's useful for repeating a section of a wave many times.

## `sin` Macro
The `sin` macro is used to generate a sin wave at a given frequency for a given duration. It's formatted as `[sin, <freq or note>, <duration>]`. You can pass it either a frequency in Hz or a note name such as `A4`, and the duration is measured in seconds.

## `sqr` Macro
The `sqr` macro is used to generate a square wave at a given frequency for a given duration. It's formatted as `[sqr, <freq or note>, <duration>]`. You can pass it either a frequency in Hz or a note name such as `A4`, and the duration is measured in seconds.