//====================================================================================================
// Base code generated with LeatherGoods - ASF.Services.Contracts
// Architecture Solutions Foundation
//
// Generated by academic at LeatherGoods V 1.0 
//====================================================================================================

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ASF.Entities;


namespace ASF.Services.Contracts
{
    
    [DataContract]
    public class CategoryFindResponse
    {
        [DataMember]
        public Category Result { get; set; }
    }
}

