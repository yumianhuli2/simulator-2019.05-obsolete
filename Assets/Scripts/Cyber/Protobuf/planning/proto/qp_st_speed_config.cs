// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: qp_st_speed_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class QpSplineConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public QpSplineConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public uint number_of_discrete_graph_t
        {
            get { return __pbn__number_of_discrete_graph_t.GetValueOrDefault(); }
            set { __pbn__number_of_discrete_graph_t = value; }
        }
        public bool ShouldSerializenumber_of_discrete_graph_t()
        {
            return __pbn__number_of_discrete_graph_t != null;
        }
        public void Resetnumber_of_discrete_graph_t()
        {
            __pbn__number_of_discrete_graph_t = null;
        }
        private uint? __pbn__number_of_discrete_graph_t;

        [global::ProtoBuf.ProtoMember(2)]
        public uint spline_order
        {
            get { return __pbn__spline_order.GetValueOrDefault(); }
            set { __pbn__spline_order = value; }
        }
        public bool ShouldSerializespline_order()
        {
            return __pbn__spline_order != null;
        }
        public void Resetspline_order()
        {
            __pbn__spline_order = null;
        }
        private uint? __pbn__spline_order;

        [global::ProtoBuf.ProtoMember(3)]
        public double speed_kernel_weight
        {
            get { return __pbn__speed_kernel_weight.GetValueOrDefault(); }
            set { __pbn__speed_kernel_weight = value; }
        }
        public bool ShouldSerializespeed_kernel_weight()
        {
            return __pbn__speed_kernel_weight != null;
        }
        public void Resetspeed_kernel_weight()
        {
            __pbn__speed_kernel_weight = null;
        }
        private double? __pbn__speed_kernel_weight;

        [global::ProtoBuf.ProtoMember(4)]
        public double accel_kernel_weight
        {
            get { return __pbn__accel_kernel_weight.GetValueOrDefault(); }
            set { __pbn__accel_kernel_weight = value; }
        }
        public bool ShouldSerializeaccel_kernel_weight()
        {
            return __pbn__accel_kernel_weight != null;
        }
        public void Resetaccel_kernel_weight()
        {
            __pbn__accel_kernel_weight = null;
        }
        private double? __pbn__accel_kernel_weight;

        [global::ProtoBuf.ProtoMember(5)]
        public double jerk_kernel_weight
        {
            get { return __pbn__jerk_kernel_weight.GetValueOrDefault(); }
            set { __pbn__jerk_kernel_weight = value; }
        }
        public bool ShouldSerializejerk_kernel_weight()
        {
            return __pbn__jerk_kernel_weight != null;
        }
        public void Resetjerk_kernel_weight()
        {
            __pbn__jerk_kernel_weight = null;
        }
        private double? __pbn__jerk_kernel_weight;

        [global::ProtoBuf.ProtoMember(6)]
        public double follow_weight
        {
            get { return __pbn__follow_weight.GetValueOrDefault(); }
            set { __pbn__follow_weight = value; }
        }
        public bool ShouldSerializefollow_weight()
        {
            return __pbn__follow_weight != null;
        }
        public void Resetfollow_weight()
        {
            __pbn__follow_weight = null;
        }
        private double? __pbn__follow_weight;

        [global::ProtoBuf.ProtoMember(7)]
        public double stop_weight
        {
            get { return __pbn__stop_weight.GetValueOrDefault(); }
            set { __pbn__stop_weight = value; }
        }
        public bool ShouldSerializestop_weight()
        {
            return __pbn__stop_weight != null;
        }
        public void Resetstop_weight()
        {
            __pbn__stop_weight = null;
        }
        private double? __pbn__stop_weight;

        [global::ProtoBuf.ProtoMember(8)]
        public double cruise_weight
        {
            get { return __pbn__cruise_weight.GetValueOrDefault(); }
            set { __pbn__cruise_weight = value; }
        }
        public bool ShouldSerializecruise_weight()
        {
            return __pbn__cruise_weight != null;
        }
        public void Resetcruise_weight()
        {
            __pbn__cruise_weight = null;
        }
        private double? __pbn__cruise_weight;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double regularization_weight
        {
            get { return __pbn__regularization_weight ?? 0.1; }
            set { __pbn__regularization_weight = value; }
        }
        public bool ShouldSerializeregularization_weight()
        {
            return __pbn__regularization_weight != null;
        }
        public void Resetregularization_weight()
        {
            __pbn__regularization_weight = null;
        }
        private double? __pbn__regularization_weight;

        [global::ProtoBuf.ProtoMember(10)]
        public double follow_drag_distance
        {
            get { return __pbn__follow_drag_distance.GetValueOrDefault(); }
            set { __pbn__follow_drag_distance = value; }
        }
        public bool ShouldSerializefollow_drag_distance()
        {
            return __pbn__follow_drag_distance != null;
        }
        public void Resetfollow_drag_distance()
        {
            __pbn__follow_drag_distance = null;
        }
        private double? __pbn__follow_drag_distance;

        [global::ProtoBuf.ProtoMember(11)]
        public double dp_st_reference_weight
        {
            get { return __pbn__dp_st_reference_weight.GetValueOrDefault(); }
            set { __pbn__dp_st_reference_weight = value; }
        }
        public bool ShouldSerializedp_st_reference_weight()
        {
            return __pbn__dp_st_reference_weight != null;
        }
        public void Resetdp_st_reference_weight()
        {
            __pbn__dp_st_reference_weight = null;
        }
        private double? __pbn__dp_st_reference_weight;

        [global::ProtoBuf.ProtoMember(12)]
        public double init_jerk_kernel_weight
        {
            get { return __pbn__init_jerk_kernel_weight.GetValueOrDefault(); }
            set { __pbn__init_jerk_kernel_weight = value; }
        }
        public bool ShouldSerializeinit_jerk_kernel_weight()
        {
            return __pbn__init_jerk_kernel_weight != null;
        }
        public void Resetinit_jerk_kernel_weight()
        {
            __pbn__init_jerk_kernel_weight = null;
        }
        private double? __pbn__init_jerk_kernel_weight;

        [global::ProtoBuf.ProtoMember(13)]
        public double yield_weight
        {
            get { return __pbn__yield_weight.GetValueOrDefault(); }
            set { __pbn__yield_weight = value; }
        }
        public bool ShouldSerializeyield_weight()
        {
            return __pbn__yield_weight != null;
        }
        public void Resetyield_weight()
        {
            __pbn__yield_weight = null;
        }
        private double? __pbn__yield_weight;

        [global::ProtoBuf.ProtoMember(14)]
        public double yield_drag_distance
        {
            get { return __pbn__yield_drag_distance.GetValueOrDefault(); }
            set { __pbn__yield_drag_distance = value; }
        }
        public bool ShouldSerializeyield_drag_distance()
        {
            return __pbn__yield_drag_distance != null;
        }
        public void Resetyield_drag_distance()
        {
            __pbn__yield_drag_distance = null;
        }
        private double? __pbn__yield_drag_distance;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QpPiecewiseConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public QpPiecewiseConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public uint number_of_evaluated_graph_t
        {
            get { return __pbn__number_of_evaluated_graph_t.GetValueOrDefault(); }
            set { __pbn__number_of_evaluated_graph_t = value; }
        }
        public bool ShouldSerializenumber_of_evaluated_graph_t()
        {
            return __pbn__number_of_evaluated_graph_t != null;
        }
        public void Resetnumber_of_evaluated_graph_t()
        {
            __pbn__number_of_evaluated_graph_t = null;
        }
        private uint? __pbn__number_of_evaluated_graph_t;

        [global::ProtoBuf.ProtoMember(2)]
        public double accel_kernel_weight
        {
            get { return __pbn__accel_kernel_weight.GetValueOrDefault(); }
            set { __pbn__accel_kernel_weight = value; }
        }
        public bool ShouldSerializeaccel_kernel_weight()
        {
            return __pbn__accel_kernel_weight != null;
        }
        public void Resetaccel_kernel_weight()
        {
            __pbn__accel_kernel_weight = null;
        }
        private double? __pbn__accel_kernel_weight;

        [global::ProtoBuf.ProtoMember(3)]
        public double jerk_kernel_weight
        {
            get { return __pbn__jerk_kernel_weight.GetValueOrDefault(); }
            set { __pbn__jerk_kernel_weight = value; }
        }
        public bool ShouldSerializejerk_kernel_weight()
        {
            return __pbn__jerk_kernel_weight != null;
        }
        public void Resetjerk_kernel_weight()
        {
            __pbn__jerk_kernel_weight = null;
        }
        private double? __pbn__jerk_kernel_weight;

        [global::ProtoBuf.ProtoMember(4)]
        public double follow_weight
        {
            get { return __pbn__follow_weight.GetValueOrDefault(); }
            set { __pbn__follow_weight = value; }
        }
        public bool ShouldSerializefollow_weight()
        {
            return __pbn__follow_weight != null;
        }
        public void Resetfollow_weight()
        {
            __pbn__follow_weight = null;
        }
        private double? __pbn__follow_weight;

        [global::ProtoBuf.ProtoMember(5)]
        public double stop_weight
        {
            get { return __pbn__stop_weight.GetValueOrDefault(); }
            set { __pbn__stop_weight = value; }
        }
        public bool ShouldSerializestop_weight()
        {
            return __pbn__stop_weight != null;
        }
        public void Resetstop_weight()
        {
            __pbn__stop_weight = null;
        }
        private double? __pbn__stop_weight;

        [global::ProtoBuf.ProtoMember(6)]
        public double cruise_weight
        {
            get { return __pbn__cruise_weight.GetValueOrDefault(); }
            set { __pbn__cruise_weight = value; }
        }
        public bool ShouldSerializecruise_weight()
        {
            return __pbn__cruise_weight != null;
        }
        public void Resetcruise_weight()
        {
            __pbn__cruise_weight = null;
        }
        private double? __pbn__cruise_weight;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double regularization_weight
        {
            get { return __pbn__regularization_weight ?? 0.1; }
            set { __pbn__regularization_weight = value; }
        }
        public bool ShouldSerializeregularization_weight()
        {
            return __pbn__regularization_weight != null;
        }
        public void Resetregularization_weight()
        {
            __pbn__regularization_weight = null;
        }
        private double? __pbn__regularization_weight;

        [global::ProtoBuf.ProtoMember(8)]
        public double follow_drag_distance
        {
            get { return __pbn__follow_drag_distance.GetValueOrDefault(); }
            set { __pbn__follow_drag_distance = value; }
        }
        public bool ShouldSerializefollow_drag_distance()
        {
            return __pbn__follow_drag_distance != null;
        }
        public void Resetfollow_drag_distance()
        {
            __pbn__follow_drag_distance = null;
        }
        private double? __pbn__follow_drag_distance;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QpStSpeedConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public QpStSpeedConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(1.2)]
        public double preferred_max_acceleration
        {
            get { return __pbn__preferred_max_acceleration ?? 1.2; }
            set { __pbn__preferred_max_acceleration = value; }
        }
        public bool ShouldSerializepreferred_max_acceleration()
        {
            return __pbn__preferred_max_acceleration != null;
        }
        public void Resetpreferred_max_acceleration()
        {
            __pbn__preferred_max_acceleration = null;
        }
        private double? __pbn__preferred_max_acceleration;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(-1.8)]
        public double preferred_min_deceleration
        {
            get { return __pbn__preferred_min_deceleration ?? -1.8; }
            set { __pbn__preferred_min_deceleration = value; }
        }
        public bool ShouldSerializepreferred_min_deceleration()
        {
            return __pbn__preferred_min_deceleration != null;
        }
        public void Resetpreferred_min_deceleration()
        {
            __pbn__preferred_min_deceleration = null;
        }
        private double? __pbn__preferred_min_deceleration;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(2)]
        public double max_acceleration
        {
            get { return __pbn__max_acceleration ?? 2; }
            set { __pbn__max_acceleration = value; }
        }
        public bool ShouldSerializemax_acceleration()
        {
            return __pbn__max_acceleration != null;
        }
        public void Resetmax_acceleration()
        {
            __pbn__max_acceleration = null;
        }
        private double? __pbn__max_acceleration;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(-4.5)]
        public double min_deceleration
        {
            get { return __pbn__min_deceleration ?? -4.5; }
            set { __pbn__min_deceleration = value; }
        }
        public bool ShouldSerializemin_deceleration()
        {
            return __pbn__min_deceleration != null;
        }
        public void Resetmin_deceleration()
        {
            __pbn__min_deceleration = null;
        }
        private double? __pbn__min_deceleration;

        [global::ProtoBuf.ProtoMember(5)]
        public QpSplineConfig qp_spline_config { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public QpPiecewiseConfig qp_piecewise_config { get; set; }

    }

}

#pragma warning restore 0612, 1591, 3021
