/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a network interface.</para>
    /// </summary>
    public class NetworkInterface
    {
        
        private string networkInterfaceId;
        private string subnetId;
        private string vpcId;
        private string availabilityZone;
        private string description;
        private string ownerId;
        private string requesterId;
        private bool? requesterManaged;
        private NetworkInterfaceStatus status;
        private string macAddress;
        private string privateIpAddress;
        private string privateDnsName;
        private bool? sourceDestCheck;
        private List<GroupIdentifier> groups = new List<GroupIdentifier>();
        private NetworkInterfaceAttachment attachment;
        private NetworkInterfaceAssociation association;
        private List<Tag> tagSet = new List<Tag>();
        private List<NetworkInterfacePrivateIpAddress> privateIpAddresses = new List<NetworkInterfacePrivateIpAddress>();


        /// <summary>
        /// The ID of the network interface.
        ///  
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;
        }

        /// <summary>
        /// The ID of the subnet.
        ///  
        /// </summary>
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }

        /// <summary>
        /// The ID of the VPC.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// The Availability Zone.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// A description.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The AWS account ID of the owner of the network interface.
        ///  
        /// </summary>
        public string OwnerId
        {
            get { return this.ownerId; }
            set { this.ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this.ownerId != null;
        }

        /// <summary>
        /// The ID of the entity that launched the instance on your behalf (for example, AWS Management Console or Auto Scaling).
        ///  
        /// </summary>
        public string RequesterId
        {
            get { return this.requesterId; }
            set { this.requesterId = value; }
        }

        // Check to see if RequesterId property is set
        internal bool IsSetRequesterId()
        {
            return this.requesterId != null;
        }

        /// <summary>
        /// Indicates whether the network interface is being managed by AWS.
        ///  
        /// </summary>
        public bool RequesterManaged
        {
            get { return this.requesterManaged ?? default(bool); }
            set { this.requesterManaged = value; }
        }

        // Check to see if RequesterManaged property is set
        internal bool IsSetRequesterManaged()
        {
            return this.requesterManaged.HasValue;
        }

        /// <summary>
        /// The status of the network interface.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>available, attaching, in-use, detaching</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public NetworkInterfaceStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The MAC address.
        ///  
        /// </summary>
        public string MacAddress
        {
            get { return this.macAddress; }
            set { this.macAddress = value; }
        }

        // Check to see if MacAddress property is set
        internal bool IsSetMacAddress()
        {
            return this.macAddress != null;
        }

        /// <summary>
        /// The IP address of the network interface within the subnet.
        ///  
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this.privateIpAddress; }
            set { this.privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this.privateIpAddress != null;
        }

        /// <summary>
        /// The private DNS name.
        ///  
        /// </summary>
        public string PrivateDnsName
        {
            get { return this.privateDnsName; }
            set { this.privateDnsName = value; }
        }

        // Check to see if PrivateDnsName property is set
        internal bool IsSetPrivateDnsName()
        {
            return this.privateDnsName != null;
        }

        /// <summary>
        /// Indicates whether traffic to or from the instance is validated.
        ///  
        /// </summary>
        public bool SourceDestCheck
        {
            get { return this.sourceDestCheck ?? default(bool); }
            set { this.sourceDestCheck = value; }
        }

        // Check to see if SourceDestCheck property is set
        internal bool IsSetSourceDestCheck()
        {
            return this.sourceDestCheck.HasValue;
        }

        /// <summary>
        /// Any security groups for the network interface.
        ///  
        /// </summary>
        public List<GroupIdentifier> Groups
        {
            get { return this.groups; }
            set { this.groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this.groups.Count > 0;
        }

        /// <summary>
        /// The network interface attachment.
        ///  
        /// </summary>
        public NetworkInterfaceAttachment Attachment
        {
            get { return this.attachment; }
            set { this.attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this.attachment != null;
        }

        /// <summary>
        /// The association information for an Elastic IP associated with the network interface.
        ///  
        /// </summary>
        public NetworkInterfaceAssociation Association
        {
            get { return this.association; }
            set { this.association = value; }
        }

        // Check to see if Association property is set
        internal bool IsSetAssociation()
        {
            return this.association != null;
        }

        /// <summary>
        /// Any tags assigned to the network interface.
        ///  
        /// </summary>
        public List<Tag> TagSet
        {
            get { return this.tagSet; }
            set { this.tagSet = value; }
        }

        // Check to see if TagSet property is set
        internal bool IsSetTagSet()
        {
            return this.tagSet.Count > 0;
        }

        /// <summary>
        /// The private IP addresses associated with the network interface.
        ///  
        /// </summary>
        public List<NetworkInterfacePrivateIpAddress> PrivateIpAddresses
        {
            get { return this.privateIpAddresses; }
            set { this.privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this.privateIpAddresses.Count > 0;
        }
    }
}
