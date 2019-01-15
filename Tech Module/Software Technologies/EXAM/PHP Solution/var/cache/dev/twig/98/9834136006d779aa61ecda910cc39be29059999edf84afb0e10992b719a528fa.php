<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_09886c37796d81d574b2448cf2a22ea32da8dad546b69f22c376ce19a869ce97 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_11ccc9abbc5d35d169cb03b589738e153bf1ad0d6d7f3080bddae4a201d2db51 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_11ccc9abbc5d35d169cb03b589738e153bf1ad0d6d7f3080bddae4a201d2db51->enter($__internal_11ccc9abbc5d35d169cb03b589738e153bf1ad0d6d7f3080bddae4a201d2db51_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_d12a47aff1c33ad5b3d0677e4e74ba565da5379a92b1f27b3cad532473041ff0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d12a47aff1c33ad5b3d0677e4e74ba565da5379a92b1f27b3cad532473041ff0->enter($__internal_d12a47aff1c33ad5b3d0677e4e74ba565da5379a92b1f27b3cad532473041ff0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_11ccc9abbc5d35d169cb03b589738e153bf1ad0d6d7f3080bddae4a201d2db51->leave($__internal_11ccc9abbc5d35d169cb03b589738e153bf1ad0d6d7f3080bddae4a201d2db51_prof);

        
        $__internal_d12a47aff1c33ad5b3d0677e4e74ba565da5379a92b1f27b3cad532473041ff0->leave($__internal_d12a47aff1c33ad5b3d0677e4e74ba565da5379a92b1f27b3cad532473041ff0_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_829a0cfc3fbf120e4fa7cf453873965d10f1706045c2591edae926ed43bc82aa = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_829a0cfc3fbf120e4fa7cf453873965d10f1706045c2591edae926ed43bc82aa->enter($__internal_829a0cfc3fbf120e4fa7cf453873965d10f1706045c2591edae926ed43bc82aa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_9c9a8e26c4590e40264034de42bd36397f4a3407866b30eb34fd7f6137e63656 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9c9a8e26c4590e40264034de42bd36397f4a3407866b30eb34fd7f6137e63656->enter($__internal_9c9a8e26c4590e40264034de42bd36397f4a3407866b30eb34fd7f6137e63656_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_9c9a8e26c4590e40264034de42bd36397f4a3407866b30eb34fd7f6137e63656->leave($__internal_9c9a8e26c4590e40264034de42bd36397f4a3407866b30eb34fd7f6137e63656_prof);

        
        $__internal_829a0cfc3fbf120e4fa7cf453873965d10f1706045c2591edae926ed43bc82aa->leave($__internal_829a0cfc3fbf120e4fa7cf453873965d10f1706045c2591edae926ed43bc82aa_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_58a48d0de951886a52ef5081f84c24285b66bfb366b588e67328ac879a09930b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_58a48d0de951886a52ef5081f84c24285b66bfb366b588e67328ac879a09930b->enter($__internal_58a48d0de951886a52ef5081f84c24285b66bfb366b588e67328ac879a09930b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_e3fec0401ddc895f832a62426ea62c5d2695cd1654a163b9cae901341aeb1498 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e3fec0401ddc895f832a62426ea62c5d2695cd1654a163b9cae901341aeb1498->enter($__internal_e3fec0401ddc895f832a62426ea62c5d2695cd1654a163b9cae901341aeb1498_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_e3fec0401ddc895f832a62426ea62c5d2695cd1654a163b9cae901341aeb1498->leave($__internal_e3fec0401ddc895f832a62426ea62c5d2695cd1654a163b9cae901341aeb1498_prof);

        
        $__internal_58a48d0de951886a52ef5081f84c24285b66bfb366b588e67328ac879a09930b->leave($__internal_58a48d0de951886a52ef5081f84c24285b66bfb366b588e67328ac879a09930b_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_bedaccb040e48ea88ee8bc85a646eb378c74d85aa46ef100888f44517f432acb = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_bedaccb040e48ea88ee8bc85a646eb378c74d85aa46ef100888f44517f432acb->enter($__internal_bedaccb040e48ea88ee8bc85a646eb378c74d85aa46ef100888f44517f432acb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_995d71f79bb5fc23e66bb208db135d60b25bdaacb851d8c88874004fb7e9841b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_995d71f79bb5fc23e66bb208db135d60b25bdaacb851d8c88874004fb7e9841b->enter($__internal_995d71f79bb5fc23e66bb208db135d60b25bdaacb851d8c88874004fb7e9841b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_995d71f79bb5fc23e66bb208db135d60b25bdaacb851d8c88874004fb7e9841b->leave($__internal_995d71f79bb5fc23e66bb208db135d60b25bdaacb851d8c88874004fb7e9841b_prof);

        
        $__internal_bedaccb040e48ea88ee8bc85a646eb378c74d85aa46ef100888f44517f432acb->leave($__internal_bedaccb040e48ea88ee8bc85a646eb378c74d85aa46ef100888f44517f432acb_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "D:\\PHP Solution\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
