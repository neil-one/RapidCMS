﻿using System;
using RapidCMS.Core.Models.State;

namespace RapidCMS.Core.Models.UI
{
    public class TreeCollectionUI
    {
        public static TreeCollectionUI None = new TreeCollectionUI("empty", "empty");

        public TreeCollectionUI(string alias, string name)
        {
            Alias = alias ?? throw new ArgumentNullException(nameof(alias));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Alias { get; private set; }
        public string Name { get; private set; }
        public string? Icon { get; internal set; }
        public PageStateModel? State { get; internal set; }
        public bool DefaultOpenEntities { get; internal set; }

        public bool EntitiesVisible { get; internal set; }
        public bool RootVisible { get; internal set; }
    }
}
