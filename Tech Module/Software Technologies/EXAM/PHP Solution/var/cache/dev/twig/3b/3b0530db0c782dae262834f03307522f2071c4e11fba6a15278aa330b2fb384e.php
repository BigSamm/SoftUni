<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_f32ad73c9bc804e7d7685ce925e27ce9c7daa98efc0b9a8c89227d7076a75563 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
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
        $__internal_6cc00938097f3ad2902325772a4e1e3c9fbc8b83a2dd71ee3e19eef0d3a54398 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6cc00938097f3ad2902325772a4e1e3c9fbc8b83a2dd71ee3e19eef0d3a54398->enter($__internal_6cc00938097f3ad2902325772a4e1e3c9fbc8b83a2dd71ee3e19eef0d3a54398_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_34f33d6a60b0be6327ea6e923fe08b0491001f1c7bd82294563bc948b414b6c4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_34f33d6a60b0be6327ea6e923fe08b0491001f1c7bd82294563bc948b414b6c4->enter($__internal_34f33d6a60b0be6327ea6e923fe08b0491001f1c7bd82294563bc948b414b6c4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_6cc00938097f3ad2902325772a4e1e3c9fbc8b83a2dd71ee3e19eef0d3a54398->leave($__internal_6cc00938097f3ad2902325772a4e1e3c9fbc8b83a2dd71ee3e19eef0d3a54398_prof);

        
        $__internal_34f33d6a60b0be6327ea6e923fe08b0491001f1c7bd82294563bc948b414b6c4->leave($__internal_34f33d6a60b0be6327ea6e923fe08b0491001f1c7bd82294563bc948b414b6c4_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_fe9ccc1c213fd6d184991d52eca5ada5a5dad629af2d9a84c6049f6d89ae4991 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_fe9ccc1c213fd6d184991d52eca5ada5a5dad629af2d9a84c6049f6d89ae4991->enter($__internal_fe9ccc1c213fd6d184991d52eca5ada5a5dad629af2d9a84c6049f6d89ae4991_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_6cc01dc52b6f33391c92a6da4d87af220a0a8b29307fec7d9d1ac72490be83d2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6cc01dc52b6f33391c92a6da4d87af220a0a8b29307fec7d9d1ac72490be83d2->enter($__internal_6cc01dc52b6f33391c92a6da4d87af220a0a8b29307fec7d9d1ac72490be83d2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_6cc01dc52b6f33391c92a6da4d87af220a0a8b29307fec7d9d1ac72490be83d2->leave($__internal_6cc01dc52b6f33391c92a6da4d87af220a0a8b29307fec7d9d1ac72490be83d2_prof);

        
        $__internal_fe9ccc1c213fd6d184991d52eca5ada5a5dad629af2d9a84c6049f6d89ae4991->leave($__internal_fe9ccc1c213fd6d184991d52eca5ada5a5dad629af2d9a84c6049f6d89ae4991_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_b77f1b4a7c8f2b9bdb1b3dcf2d3ff2505939e0b02f98fab13e187dd326e1a1e4 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b77f1b4a7c8f2b9bdb1b3dcf2d3ff2505939e0b02f98fab13e187dd326e1a1e4->enter($__internal_b77f1b4a7c8f2b9bdb1b3dcf2d3ff2505939e0b02f98fab13e187dd326e1a1e4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_63d8862fa87f82632909403c24720ce341a4ae7683bfbbfac995d1fbc8b554ee = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_63d8862fa87f82632909403c24720ce341a4ae7683bfbbfac995d1fbc8b554ee->enter($__internal_63d8862fa87f82632909403c24720ce341a4ae7683bfbbfac995d1fbc8b554ee_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_63d8862fa87f82632909403c24720ce341a4ae7683bfbbfac995d1fbc8b554ee->leave($__internal_63d8862fa87f82632909403c24720ce341a4ae7683bfbbfac995d1fbc8b554ee_prof);

        
        $__internal_b77f1b4a7c8f2b9bdb1b3dcf2d3ff2505939e0b02f98fab13e187dd326e1a1e4->leave($__internal_b77f1b4a7c8f2b9bdb1b3dcf2d3ff2505939e0b02f98fab13e187dd326e1a1e4_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_4f1ae1d71a5c3a1f154b759bc583dce15a4c113e9f47e4f50126e7fde2ed544c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4f1ae1d71a5c3a1f154b759bc583dce15a4c113e9f47e4f50126e7fde2ed544c->enter($__internal_4f1ae1d71a5c3a1f154b759bc583dce15a4c113e9f47e4f50126e7fde2ed544c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_be84e5a1362c21507db1c04ade5a85d7c2b64891fcc519049e2a7271ba78dcee = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_be84e5a1362c21507db1c04ade5a85d7c2b64891fcc519049e2a7271ba78dcee->enter($__internal_be84e5a1362c21507db1c04ade5a85d7c2b64891fcc519049e2a7271ba78dcee_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_be84e5a1362c21507db1c04ade5a85d7c2b64891fcc519049e2a7271ba78dcee->leave($__internal_be84e5a1362c21507db1c04ade5a85d7c2b64891fcc519049e2a7271ba78dcee_prof);

        
        $__internal_4f1ae1d71a5c3a1f154b759bc583dce15a4c113e9f47e4f50126e7fde2ed544c->leave($__internal_4f1ae1d71a5c3a1f154b759bc583dce15a4c113e9f47e4f50126e7fde2ed544c_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
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

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "D:\\PHP Solution\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
