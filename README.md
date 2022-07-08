# WhoContained106
A simple plugin that will broadcast a message to all players that says who sacrificed himself to recontain SCP-106.

The installation is easy and settings are fully configurable:

## Installation
Windows: Put the plugin (.dll) in %appdata%/Exiled/Plugins
Linux: Put the plugin (.dll) in ~/.config/EXILED/Plugins

## Settings:

### is_enabled: true
Defines if the plugin should be enabled by default at startup

### message_duration_in_seconds: 10
Time the message will remain in all player's screen

### message: '{Player} se ha sacrificado como {Role} para eliminar a SCP-106'
Custom message for the players, {Player} will be replaced with the player nickname and {Role} will be replaced with the role that player was (these are optional settings and you can just remove the {Player} or {Role})
