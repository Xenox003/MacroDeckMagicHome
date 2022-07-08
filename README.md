# MacroDeckMagicHome

## This documentation is currently outdated and will be updated upon release of this branch

This is a plugin for SuchByte's MacroDeck 2, it does not function as a standalone app
<img alt="Macro Deck 2 Community Plugin" height="64px" align="center" href="https://macrodeck.org" src="https://macrodeck.org/images/macro_deck_2_community_plugin.png"/>

Magic Home is a Smart Home system mainly driving LED Strip controllers, this plugin provides a useful set of Actions to control your Magic Home Devices with Macro Deck.

## Features
#### Available Actions
| Action | Function | Status |
| --- | --- | --- |
| Toggle Light | Turn you Light on or off | - |
| Change Color | Change the RGB Values of your Light | - |

#### Device Manager
This plugin provides a Device Manager to dynamically add, remove or scan for Devices.

## How does it work?

This plugin uses the LEDNet Protocol to communicate with compatible Smart Home devices in your Local Network.
Sometimes you might not be able to find any devices in the Device Manager using the Discovery option, in this specific case you should consider adding the device manually using its IP Address

## Third Party Source
This plugin is built using

- [Macro Deck 2 by SuchByte (Apache License 2.0)](https://macrodeck.org)
- [Magic Home .NET Library (GNU)](https://github.com/nathanielxd/magic-home) (Slightly modified)
