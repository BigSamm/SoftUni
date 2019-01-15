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
        $__internal_0e5c2c43d88868eed85340c1a5f254047755678d950282989f81fbae166f8f3a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_0e5c2c43d88868eed85340c1a5f254047755678d950282989f81fbae166f8f3a->enter($__internal_0e5c2c43d88868eed85340c1a5f254047755678d950282989f81fbae166f8f3a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_ec2aeba0f74ab8839b90ecef0e958b8ed6230187c195e69619779fc07c2602ab = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ec2aeba0f74ab8839b90ecef0e958b8ed6230187c195e69619779fc07c2602ab->enter($__internal_ec2aeba0f74ab8839b90ecef0e958b8ed6230187c195e69619779fc07c2602ab_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_0e5c2c43d88868eed85340c1a5f254047755678d950282989f81fbae166f8f3a->leave($__internal_0e5c2c43d88868eed85340c1a5f254047755678d950282989f81fbae166f8f3a_prof);

        
        $__internal_ec2aeba0f74ab8839b90ecef0e958b8ed6230187c195e69619779fc07c2602ab->leave($__internal_ec2aeba0f74ab8839b90ecef0e958b8ed6230187c195e69619779fc07c2602ab_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_20270ce1ea89fb983f299a12c878cbae152a4878dd96f8ec63db3b87261f1822 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_20270ce1ea89fb983f299a12c878cbae152a4878dd96f8ec63db3b87261f1822->enter($__internal_20270ce1ea89fb983f299a12c878cbae152a4878dd96f8ec63db3b87261f1822_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_c00ac0b45e3a27c4d19e734d715eca97ddfde7470e487e110cabeed2a48ab652 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c00ac0b45e3a27c4d19e734d715eca97ddfde7470e487e110cabeed2a48ab652->enter($__internal_c00ac0b45e3a27c4d19e734d715eca97ddfde7470e487e110cabeed2a48ab652_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_c00ac0b45e3a27c4d19e734d715eca97ddfde7470e487e110cabeed2a48ab652->leave($__internal_c00ac0b45e3a27c4d19e734d715eca97ddfde7470e487e110cabeed2a48ab652_prof);

        
        $__internal_20270ce1ea89fb983f299a12c878cbae152a4878dd96f8ec63db3b87261f1822->leave($__internal_20270ce1ea89fb983f299a12c878cbae152a4878dd96f8ec63db3b87261f1822_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_7c7458594e9803e1b5e54d4b05de76855cc2411bfff5ffca5bab460530167369 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7c7458594e9803e1b5e54d4b05de76855cc2411bfff5ffca5bab460530167369->enter($__internal_7c7458594e9803e1b5e54d4b05de76855cc2411bfff5ffca5bab460530167369_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_e3e2f429f06fb6f1a44d498931c204718e886fa2f63df8017d4b729622a80d78 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e3e2f429f06fb6f1a44d498931c204718e886fa2f63df8017d4b729622a80d78->enter($__internal_e3e2f429f06fb6f1a44d498931c204718e886fa2f63df8017d4b729622a80d78_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_e3e2f429f06fb6f1a44d498931c204718e886fa2f63df8017d4b729622a80d78->leave($__internal_e3e2f429f06fb6f1a44d498931c204718e886fa2f63df8017d4b729622a80d78_prof);

        
        $__internal_7c7458594e9803e1b5e54d4b05de76855cc2411bfff5ffca5bab460530167369->leave($__internal_7c7458594e9803e1b5e54d4b05de76855cc2411bfff5ffca5bab460530167369_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_6a801210ab4e9ca706563d28f22e0fe7a0924634a6f10cac211ba58d57eb8399 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6a801210ab4e9ca706563d28f22e0fe7a0924634a6f10cac211ba58d57eb8399->enter($__internal_6a801210ab4e9ca706563d28f22e0fe7a0924634a6f10cac211ba58d57eb8399_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_cbe14c1bcde06b5cc46447ce4e6d5edca44b399b1ca00e6d886cf098e474ad6a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cbe14c1bcde06b5cc46447ce4e6d5edca44b399b1ca00e6d886cf098e474ad6a->enter($__internal_cbe14c1bcde06b5cc46447ce4e6d5edca44b399b1ca00e6d886cf098e474ad6a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_cbe14c1bcde06b5cc46447ce4e6d5edca44b399b1ca00e6d886cf098e474ad6a->leave($__internal_cbe14c1bcde06b5cc46447ce4e6d5edca44b399b1ca00e6d886cf098e474ad6a_prof);

        
        $__internal_6a801210ab4e9ca706563d28f22e0fe7a0924634a6f10cac211ba58d57eb8399->leave($__internal_6a801210ab4e9ca706563d28f22e0fe7a0924634a6f10cac211ba58d57eb8399_prof);

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
", "@WebProfiler/Collector/router.html.twig", "D:\\PHP Skeleton 2\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
