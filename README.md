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

## Device Manager
This plugin provides a Device Manager to dynamically add, remove or scan for Devices.
#### Using the Device Manager
![image](https://user-images.githubusercontent.com/68594244/178349867-0f525405-8925-44f9-b604-67ee14d59613.png)

On the left side you can see the device list, this shows you all registered devices.
You have got three buttons and a Input field above the Device list:
 - Add Device Button (Plus Icon) 
 - Remove Device Button (Trash Icon)
 - Device Discovery Button (Magnifying Glass Icon)
The Add button is used to manually add devices to the plugin, if you enter an IP-Address in the input field and press this button it will add the device to the device list and attempt to connect to it.
The Remove button is used to delete existing devices, if you select an Device in the List and press this button, it will delete the Device.
The Discovery button is used to search for Magic Home Devices in your network, this may not always work.

The Input box to the right of the Buttons is the Discovery Timeout, it indicates how long the plugin will search for devices, if you have a very slow connection to your router you may set this value to be higher. (Don't forget to press save)

#### Device Configuration

On the right side in the device manager you can see the device configuration, this one is rather simple as of now:
 - IP Field: (View Only) Shows the devices IP-Address
 - Name Field: Set a name for your device to identify more easily
 - Connected Field: (View Only) Shows if your device is connected or not (This field does not automatically update, you might either press the save button to reload or close and then open the device manager again.


## Third Party Source
This plugin is built using

- [Macro Deck 2 by SuchByte (Apache License 2.0)](https://macrodeck.org)
- [Magic Home .NET Library (GNU)](https://github.com/nathanielxd/magic-home) (Slightly modified)
