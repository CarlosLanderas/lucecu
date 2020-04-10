﻿using k8s;
using k8s.Models;
using System.Collections.Generic;

namespace __ProjectName__.Crd.Abstractions
{
    public abstract class CustomResourceList<TCustomResource> : KubernetesObject
        where TCustomResource : CustomResource
    {
        public V1ListMeta Metadata { get; set; }

        public List<TCustomResource> Items { get; set; }
    }
}
