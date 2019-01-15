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
        $__internal_830e22ae353fe89a8a027de4a8d92e8459cd9d60ddb580450eccd6ca276ee00d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_830e22ae353fe89a8a027de4a8d92e8459cd9d60ddb580450eccd6ca276ee00d->enter($__internal_830e22ae353fe89a8a027de4a8d92e8459cd9d60ddb580450eccd6ca276ee00d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_6d7807578c2402808074eab5f53690f4f34b48ef815f429adf19edb149bd9b71 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6d7807578c2402808074eab5f53690f4f34b48ef815f429adf19edb149bd9b71->enter($__internal_6d7807578c2402808074eab5f53690f4f34b48ef815f429adf19edb149bd9b71_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_830e22ae353fe89a8a027de4a8d92e8459cd9d60ddb580450eccd6ca276ee00d->leave($__internal_830e22ae353fe89a8a027de4a8d92e8459cd9d60ddb580450eccd6ca276ee00d_prof);

        
        $__internal_6d7807578c2402808074eab5f53690f4f34b48ef815f429adf19edb149bd9b71->leave($__internal_6d7807578c2402808074eab5f53690f4f34b48ef815f429adf19edb149bd9b71_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_064916180362bce33bed55bd885ffa3cb170e566b7ae87e95be0583bf759892f = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_064916180362bce33bed55bd885ffa3cb170e566b7ae87e95be0583bf759892f->enter($__internal_064916180362bce33bed55bd885ffa3cb170e566b7ae87e95be0583bf759892f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_090272bb084bb57dd5a52f7854bb6772175ed6d79442fffd0cc2f186e6910f2f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_090272bb084bb57dd5a52f7854bb6772175ed6d79442fffd0cc2f186e6910f2f->enter($__internal_090272bb084bb57dd5a52f7854bb6772175ed6d79442fffd0cc2f186e6910f2f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

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
        
        $__internal_090272bb084bb57dd5a52f7854bb6772175ed6d79442fffd0cc2f186e6910f2f->leave($__internal_090272bb084bb57dd5a52f7854bb6772175ed6d79442fffd0cc2f186e6910f2f_prof);

        
        $__internal_064916180362bce33bed55bd885ffa3cb170e566b7ae87e95be0583bf759892f->leave($__internal_064916180362bce33bed55bd885ffa3cb170e566b7ae87e95be0583bf759892f_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_9a83a1a66a2dd834831cb024f21f827de79ae985989cc6b7c75a5f71224cf241 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_9a83a1a66a2dd834831cb024f21f827de79ae985989cc6b7c75a5f71224cf241->enter($__internal_9a83a1a66a2dd834831cb024f21f827de79ae985989cc6b7c75a5f71224cf241_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_4e64871039826346c6a3819e08202acd2552d9f88ec14457ebe31ee659dc04de = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4e64871039826346c6a3819e08202acd2552d9f88ec14457ebe31ee659dc04de->enter($__internal_4e64871039826346c6a3819e08202acd2552d9f88ec14457ebe31ee659dc04de_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

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
        
        $__internal_4e64871039826346c6a3819e08202acd2552d9f88ec14457ebe31ee659dc04de->leave($__internal_4e64871039826346c6a3819e08202acd2552d9f88ec14457ebe31ee659dc04de_prof);

        
        $__internal_9a83a1a66a2dd834831cb024f21f827de79ae985989cc6b7c75a5f71224cf241->leave($__internal_9a83a1a66a2dd834831cb024f21f827de79ae985989cc6b7c75a5f71224cf241_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_c2ec07267c1d31cc7f73a2d1794d77ef14438cabf975cc7aeb80f60863df7431 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c2ec07267c1d31cc7f73a2d1794d77ef14438cabf975cc7aeb80f60863df7431->enter($__internal_c2ec07267c1d31cc7f73a2d1794d77ef14438cabf975cc7aeb80f60863df7431_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_12715cd174353511139c8d65b977396c8ba5ba2dfca7b40385180090e280750d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_12715cd174353511139c8d65b977396c8ba5ba2dfca7b40385180090e280750d->enter($__internal_12715cd174353511139c8d65b977396c8ba5ba2dfca7b40385180090e280750d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

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
        
        $__internal_12715cd174353511139c8d65b977396c8ba5ba2dfca7b40385180090e280750d->leave($__internal_12715cd174353511139c8d65b977396c8ba5ba2dfca7b40385180090e280750d_prof);

        
        $__internal_c2ec07267c1d31cc7f73a2d1794d77ef14438cabf975cc7aeb80f60863df7431->leave($__internal_c2ec07267c1d31cc7f73a2d1794d77ef14438cabf975cc7aeb80f60863df7431_prof);

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
", "@WebProfiler/Collector/exception.html.twig", "D:\\PHP Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
