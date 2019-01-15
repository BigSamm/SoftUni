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
        $__internal_914d7f255fa6d567c8d15e7bdb2b6f6dd5154b043178829131a637d225fb02e3 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_914d7f255fa6d567c8d15e7bdb2b6f6dd5154b043178829131a637d225fb02e3->enter($__internal_914d7f255fa6d567c8d15e7bdb2b6f6dd5154b043178829131a637d225fb02e3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_d6be10473032db06623a3357872cd81accb98390cfc1fe7edfa9205600dd24ef = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d6be10473032db06623a3357872cd81accb98390cfc1fe7edfa9205600dd24ef->enter($__internal_d6be10473032db06623a3357872cd81accb98390cfc1fe7edfa9205600dd24ef_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_914d7f255fa6d567c8d15e7bdb2b6f6dd5154b043178829131a637d225fb02e3->leave($__internal_914d7f255fa6d567c8d15e7bdb2b6f6dd5154b043178829131a637d225fb02e3_prof);

        
        $__internal_d6be10473032db06623a3357872cd81accb98390cfc1fe7edfa9205600dd24ef->leave($__internal_d6be10473032db06623a3357872cd81accb98390cfc1fe7edfa9205600dd24ef_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_ef56096694db04d43fe176a7d08ecdb23f7a1da5c371580f1087878172ee1ee8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ef56096694db04d43fe176a7d08ecdb23f7a1da5c371580f1087878172ee1ee8->enter($__internal_ef56096694db04d43fe176a7d08ecdb23f7a1da5c371580f1087878172ee1ee8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_f1ff93fd9804bedf5d34333fe8ca44fe5f78e869bc2676176c37a57befb6656d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f1ff93fd9804bedf5d34333fe8ca44fe5f78e869bc2676176c37a57befb6656d->enter($__internal_f1ff93fd9804bedf5d34333fe8ca44fe5f78e869bc2676176c37a57befb6656d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_f1ff93fd9804bedf5d34333fe8ca44fe5f78e869bc2676176c37a57befb6656d->leave($__internal_f1ff93fd9804bedf5d34333fe8ca44fe5f78e869bc2676176c37a57befb6656d_prof);

        
        $__internal_ef56096694db04d43fe176a7d08ecdb23f7a1da5c371580f1087878172ee1ee8->leave($__internal_ef56096694db04d43fe176a7d08ecdb23f7a1da5c371580f1087878172ee1ee8_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_7675f3b7e50d26773d26fe5d9aec959914368bebc99c809ac30fd12a4769c664 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7675f3b7e50d26773d26fe5d9aec959914368bebc99c809ac30fd12a4769c664->enter($__internal_7675f3b7e50d26773d26fe5d9aec959914368bebc99c809ac30fd12a4769c664_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_e65a088972d50346a027b16b6f1777354ba8bc7ec250710d3c29badd25440b80 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e65a088972d50346a027b16b6f1777354ba8bc7ec250710d3c29badd25440b80->enter($__internal_e65a088972d50346a027b16b6f1777354ba8bc7ec250710d3c29badd25440b80_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_e65a088972d50346a027b16b6f1777354ba8bc7ec250710d3c29badd25440b80->leave($__internal_e65a088972d50346a027b16b6f1777354ba8bc7ec250710d3c29badd25440b80_prof);

        
        $__internal_7675f3b7e50d26773d26fe5d9aec959914368bebc99c809ac30fd12a4769c664->leave($__internal_7675f3b7e50d26773d26fe5d9aec959914368bebc99c809ac30fd12a4769c664_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_053bcf4f322208fcd6a6439f4572ec6ae8ac55fb38ba4c282a3db67cdc4a8c61 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_053bcf4f322208fcd6a6439f4572ec6ae8ac55fb38ba4c282a3db67cdc4a8c61->enter($__internal_053bcf4f322208fcd6a6439f4572ec6ae8ac55fb38ba4c282a3db67cdc4a8c61_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_3196ff0d5fc3538a1f9eca0277e5b3dbb784690dc689c476122a5ee06168abfc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3196ff0d5fc3538a1f9eca0277e5b3dbb784690dc689c476122a5ee06168abfc->enter($__internal_3196ff0d5fc3538a1f9eca0277e5b3dbb784690dc689c476122a5ee06168abfc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_3196ff0d5fc3538a1f9eca0277e5b3dbb784690dc689c476122a5ee06168abfc->leave($__internal_3196ff0d5fc3538a1f9eca0277e5b3dbb784690dc689c476122a5ee06168abfc_prof);

        
        $__internal_053bcf4f322208fcd6a6439f4572ec6ae8ac55fb38ba4c282a3db67cdc4a8c61->leave($__internal_053bcf4f322208fcd6a6439f4572ec6ae8ac55fb38ba4c282a3db67cdc4a8c61_prof);

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
", "@WebProfiler/Collector/router.html.twig", "D:\\PHP Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
