﻿using System.Collections.Generic;

namespace Amazon.Ec2
{
    public class DescribeImagesRequest : DescribeRequest
    {        
        public List<string> ImageIds { get; } = new List<string>();

        public AwsRequest ToParams()
        {
            var parameters = GetParameters("DescribeImages");

            AddIds(parameters, "ImageId", ImageIds);

            return parameters;
        }
    }
}