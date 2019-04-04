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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ess.Model.V20140828;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeAccountAttributesResponseUnmarshaller
    {
        public static DescribeAccountAttributesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccountAttributesResponse describeAccountAttributesResponse = new DescribeAccountAttributesResponse();

			describeAccountAttributesResponse.HttpResponse = context.HttpResponse;
			describeAccountAttributesResponse.MaxNumberOfScalingGroups = context.IntegerValue("DescribeAccountAttributes.MaxNumberOfScalingGroups");
			describeAccountAttributesResponse.MaxNumberOfScalingConfigurations = context.IntegerValue("DescribeAccountAttributes.MaxNumberOfScalingConfigurations");
			describeAccountAttributesResponse.MaxNumberOfScalingRules = context.IntegerValue("DescribeAccountAttributes.MaxNumberOfScalingRules");
			describeAccountAttributesResponse.MaxNumberOfScheduledTasks = context.IntegerValue("DescribeAccountAttributes.MaxNumberOfScheduledTasks");
			describeAccountAttributesResponse.MaxNumberOfScalingInstances = context.IntegerValue("DescribeAccountAttributes.MaxNumberOfScalingInstances");
			describeAccountAttributesResponse.MaxNumberOfDBInstances = context.IntegerValue("DescribeAccountAttributes.MaxNumberOfDBInstances");
			describeAccountAttributesResponse.MaxNumberOfLoadBalancers = context.IntegerValue("DescribeAccountAttributes.MaxNumberOfLoadBalancers");
			describeAccountAttributesResponse.MaxNumberOfMinSize = context.IntegerValue("DescribeAccountAttributes.MaxNumberOfMinSize");
			describeAccountAttributesResponse.MaxNumberOfMaxSize = context.IntegerValue("DescribeAccountAttributes.MaxNumberOfMaxSize");
        
			return describeAccountAttributesResponse;
        }
    }
}
