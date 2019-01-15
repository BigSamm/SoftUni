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
        $__internal_e3504275ca80c6a2fa430a571483fc33e72064f67bf2aba9233cd77210c79ccd = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e3504275ca80c6a2fa430a571483fc33e72064f67bf2aba9233cd77210c79ccd->enter($__internal_e3504275ca80c6a2fa430a571483fc33e72064f67bf2aba9233cd77210c79ccd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_7a69c3494c9d0e7b222d0c663ee60fdf4555a703f597b979f058c5ed719fc696 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7a69c3494c9d0e7b222d0c663ee60fdf4555a703f597b979f058c5ed719fc696->enter($__internal_7a69c3494c9d0e7b222d0c663ee60fdf4555a703f597b979f058c5ed719fc696_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_e3504275ca80c6a2fa430a571483fc33e72064f67bf2aba9233cd77210c79ccd->leave($__internal_e3504275ca80c6a2fa430a571483fc33e72064f67bf2aba9233cd77210c79ccd_prof);

        
        $__internal_7a69c3494c9d0e7b222d0c663ee60fdf4555a703f597b979f058c5ed719fc696->leave($__internal_7a69c3494c9d0e7b222d0c663ee60fdf4555a703f597b979f058c5ed719fc696_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_c054fd6436d6656ccf5ec2ec88c84d8b6813532bcd0fcb42cc0905c89e6626f0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c054fd6436d6656ccf5ec2ec88c84d8b6813532bcd0fcb42cc0905c89e6626f0->enter($__internal_c054fd6436d6656ccf5ec2ec88c84d8b6813532bcd0fcb42cc0905c89e6626f0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_e969a4f74087f5f311d06f4777f7b19aac58b74cad5492574f72d20472282242 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e969a4f74087f5f311d06f4777f7b19aac58b74cad5492574f72d20472282242->enter($__internal_e969a4f74087f5f311d06f4777f7b19aac58b74cad5492574f72d20472282242_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

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
        
        $__internal_e969a4f74087f5f311d06f4777f7b19aac58b74cad5492574f72d20472282242->leave($__internal_e969a4f74087f5f311d06f4777f7b19aac58b74cad5492574f72d20472282242_prof);

        
        $__internal_c054fd6436d6656ccf5ec2ec88c84d8b6813532bcd0fcb42cc0905c89e6626f0->leave($__internal_c054fd6436d6656ccf5ec2ec88c84d8b6813532bcd0fcb42cc0905c89e6626f0_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_e120bb219f0a34421cd250ff52ba542dd7fbf72a498448c08da7eb79c5745dee = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e120bb219f0a34421cd250ff52ba542dd7fbf72a498448c08da7eb79c5745dee->enter($__internal_e120bb219f0a34421cd250ff52ba542dd7fbf72a498448c08da7eb79c5745dee_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_75f6a7399f48c1f00515d4a8de6716605d18018dd8da430eaa3c136ff11ba7df = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_75f6a7399f48c1f00515d4a8de6716605d18018dd8da430eaa3c136ff11ba7df->enter($__internal_75f6a7399f48c1f00515d4a8de6716605d18018dd8da430eaa3c136ff11ba7df_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

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
        
        $__internal_75f6a7399f48c1f00515d4a8de6716605d18018dd8da430eaa3c136ff11ba7df->leave($__internal_75f6a7399f48c1f00515d4a8de6716605d18018dd8da430eaa3c136ff11ba7df_prof);

        
        $__internal_e120bb219f0a34421cd250ff52ba542dd7fbf72a498448c08da7eb79c5745dee->leave($__internal_e120bb219f0a34421cd250ff52ba542dd7fbf72a498448c08da7eb79c5745dee_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_875e0c40348edabfbbbe45fba0d937d8ecb7d5fe3141e8eb1e0424bf3ee88c12 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_875e0c40348edabfbbbe45fba0d937d8ecb7d5fe3141e8eb1e0424bf3ee88c12->enter($__internal_875e0c40348edabfbbbe45fba0d937d8ecb7d5fe3141e8eb1e0424bf3ee88c12_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_37ef3c0a9e1d59ed1dd636e6ebfc908125c0477a6fd5fa06a8ecb6360d8db4dc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_37ef3c0a9e1d59ed1dd636e6ebfc908125c0477a6fd5fa06a8ecb6360d8db4dc->enter($__internal_37ef3c0a9e1d59ed1dd636e6ebfc908125c0477a6fd5fa06a8ecb6360d8db4dc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

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
        
        $__internal_37ef3c0a9e1d59ed1dd636e6ebfc908125c0477a6fd5fa06a8ecb6360d8db4dc->leave($__internal_37ef3c0a9e1d59ed1dd636e6ebfc908125c0477a6fd5fa06a8ecb6360d8db4dc_prof);

        
        $__internal_875e0c40348edabfbbbe45fba0d937d8ecb7d5fe3141e8eb1e0424bf3ee88c12->leave($__internal_875e0c40348edabfbbbe45fba0d937d8ecb7d5fe3141e8eb1e0424bf3ee88c12_prof);

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
", "@WebProfiler/Collector/exception.html.twig", "D:\\PHP Skeleton 2\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
