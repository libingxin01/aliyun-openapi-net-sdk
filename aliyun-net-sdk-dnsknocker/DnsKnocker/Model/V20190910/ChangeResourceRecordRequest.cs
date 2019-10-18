/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.DnsKnocker.Transform;
using Aliyun.Acs.DnsKnocker.Transform.V20190910;

namespace Aliyun.Acs.DnsKnocker.Model.V20190910
{
    public class ChangeResourceRecordRequest : RpcAcsRequest<ChangeResourceRecordResponse>
    {
        public ChangeResourceRecordRequest()
            : base("DnsKnocker", "2019-09-10", "ChangeResourceRecord", "dns_knocker", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string accessID;

		private string accessSecret;

		private string newRRInfo;

		private string zoneName;

		private string transactionId;

		private string group;

		private string oldRRInfo;

		public string AccessID
		{
			get
			{
				return accessID;
			}
			set	
			{
				accessID = value;
				DictionaryUtil.Add(BodyParameters, "AccessID", value);
			}
		}

		public string AccessSecret
		{
			get
			{
				return accessSecret;
			}
			set	
			{
				accessSecret = value;
				DictionaryUtil.Add(BodyParameters, "AccessSecret", value);
			}
		}

		public string NewRRInfo
		{
			get
			{
				return newRRInfo;
			}
			set	
			{
				newRRInfo = value;
				DictionaryUtil.Add(BodyParameters, "NewRRInfo", value);
			}
		}

		public string ZoneName
		{
			get
			{
				return zoneName;
			}
			set	
			{
				zoneName = value;
				DictionaryUtil.Add(BodyParameters, "ZoneName", value);
			}
		}

		public string TransactionId
		{
			get
			{
				return transactionId;
			}
			set	
			{
				transactionId = value;
				DictionaryUtil.Add(BodyParameters, "TransactionId", value);
			}
		}

		public string Group
		{
			get
			{
				return group;
			}
			set	
			{
				group = value;
				DictionaryUtil.Add(BodyParameters, "Group", value);
			}
		}

		public string OldRRInfo
		{
			get
			{
				return oldRRInfo;
			}
			set	
			{
				oldRRInfo = value;
				DictionaryUtil.Add(BodyParameters, "OldRRInfo", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ChangeResourceRecordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ChangeResourceRecordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
