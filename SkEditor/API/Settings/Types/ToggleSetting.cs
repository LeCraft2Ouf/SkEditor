﻿using Avalonia.Controls;
using Newtonsoft.Json.Linq;
using System;

namespace SkEditor.API.Settings.Types;

/// <summary>
/// Represent a setting that can be toggled on or off.
/// </summary>
public class ToggleSetting : ISettingType
{
    public object Deserialize(JToken value)
    {
        return value.Value<bool>();
    }

    public JToken Serialize(object value)
    {
        return new JValue(value);
    }

    public Control CreateControl(object raw, Action<object> onChanged)
    {
        var value = (bool)raw;
        var toggle = new ToggleSwitch { IsChecked = value };
        toggle.IsCheckedChanged += (_, _) => onChanged(toggle.IsChecked ?? false);
        return toggle;
    }

    public bool IsSelfManaged => false;
}